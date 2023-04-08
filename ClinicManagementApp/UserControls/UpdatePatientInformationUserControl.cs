using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ClinicManagementApp.UserControls
{
    public partial class UpdatePatientInformationUserControl : UserControl
    {
        private PatientController _patientController;
        private Patient _patient;
        /// <summary>
        /// Initializes the User Control
        /// </summary>
        public UpdatePatientInformationUserControl()
        {
            InitializeComponent();
            this._patientController= new PatientController();
            this._patient = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            DateTime dob = this.dateOfBirthDateTimePicker.Value;

            this.patientSearchDataGridView.DataSource = _patientController.GetPatientByNameDOB(firstName, lastName, dob);
        }

        private void PatientSearchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientID = patientSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this._patient = this._patientController.GetPatientByID(Int32.Parse(patientID));

            if (_patient != null)
            {
                patientBindingSource.DataSource = _patient;
                patientBindingSource.ResetBindings(true);
                this.updatePatientButton.Enabled = true;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_patient != null)
            {
                this.dateOfBirthDateTimePicker.Value = this._patient.DateOfBirth.Date;
            }
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameResultsTextBox.Text.Trim();
            string firstName = this.firstNameResultsTextBox.Text.Trim();
            DateTime dateOfBirth = this.dateOfBirthResultsDateTimePicker1.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexTextBox.Text.Trim();
            string ssn = this.sSNTextBox.Text.Trim();
            if (string.IsNullOrEmpty(ssn))
            {
                ssn = "";
            }
            Patient oldPatient = _patient;


            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dateOfBirth > DateTime.Now ||string.IsNullOrEmpty(address) 
                || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || !IsValidZipCode(zip) 
                || !IsPhoneNumberValid(phone) || string.IsNullOrEmpty(sex) || !IsSSNValid(ssn))
            {
                this.ShowInvalidErrorMessage();
            }
            else
            {
                bool success = this._patientController.UpdatePatient(oldPatient.RecordID, lastName, firstName, dateOfBirth, address, city, state, zip, phone, sex, ssn);
                if (success)
                {
                    MessageBox.Show("Patient successfully updated!", "Patient Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetForm();
                } 
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            this.HideInvalidErrorMessages();
        }

        private void ResetForm()
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.dateOfBirthDateTimePicker.Value = DateTime.Now;
            this.searchButton_Click(null, null);

            this._patient = null;
            this.patientBindingSource.DataSource = this._patientController.GetPatientByNameDOB("", "", DateTime.Now);
            this.updatePatientButton.Enabled = false;
        }

        private void ShowInvalidErrorMessage()
        {
            if (string.IsNullOrEmpty(lastNameResultsTextBox.Text) || string.IsNullOrWhiteSpace(lastNameResultsTextBox.Text))
            {
                this.lastNameErrorLabel.Text = "Please enter your last name.";
                this.lastNameErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(firstNameResultsTextBox.Text) || string.IsNullOrWhiteSpace(firstNameResultsTextBox.Text))
            {
                this.firstNameErrorLabel.Text = "Please enter your first name.";
                this.firstNameErrorLabel.ForeColor = Color.Red;
            }

            if (dateOfBirthResultsDateTimePicker1.Value > DateTime.Now)
            {
                this.DOBErrorLabel.Text = "DOB cannot be in the future.";
                this.DOBErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) || addressTextBox.Text.Length < 5)
            {
                this.addressErrorLabel.Text = "Please enter your full street address.";
                this.addressErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                this.cityErrorLabel.Text = "Please enter your city.";
                this.cityErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                this.stateErrorLabel.Text = "Please select your state abbreviation.";
                this.stateErrorLabel.ForeColor = Color.Red;
            }

            if (!IsValidZipCode(zipTextBox.Text))
            {
                this.zipErrorLabel.Text = "Please enter a valid zipcode.";
                this.zipErrorLabel.ForeColor = Color.Red;
            }

            if (!IsPhoneNumberValid(phoneTextBox.Text))
            {
                this.phoneErrorLabel.Text = "Please enter your 10 digit phone number, numbers only.";
                this.phoneErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(sexTextBox.Text))
            {
                this.sexErrorMessageLabel.Text = "Please enter a sex.";
                this.sexErrorMessageLabel.ForeColor = Color.Red;
            }
            
            if (!IsSSNValid(sSNTextBox.Text))
            {
                this.ssnErrorMessageLabel.Text = "Please enter a valid 8 digit SSN, numbers only.";
                this.ssnErrorMessageLabel.ForeColor = Color.Red;
            }
        }

        private bool IsValidZipCode(string zip)
        {
            string usZipRegEx = @"^\d{5}(\d{4})?$";

            bool validZipCode = true;
            if ((!Regex.Match(zip, usZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string phoneRegEx = @"^\d{10}$";
            bool validPhoneNumber = true;
            if (!Regex.Match(phoneNumber, phoneRegEx).Success)
            {
                validPhoneNumber = false;
            }
            return validPhoneNumber;
        }

        private bool IsSSNValid(string ssn)
        {
            string ssnRegEx = @"^[0-9]{8}$";
            bool validSSN = true;
            if (ssn.Equals(""))
            {
                validSSN = true;
            }
            else if (!Regex.Match(ssn, ssnRegEx).Success)
            {
                validSSN = false;
            }
            return validSSN;
        }


        private void HideInvalidErrorMessages()
        {
            this.lastNameErrorLabel.Text = "";
            this.firstNameErrorLabel.Text = "";
            this.DOBErrorLabel.Text = "";
            this.addressErrorLabel.Text = "";
            this.phoneErrorLabel.Text = "";
            this.cityErrorLabel.Text = "";
            this.stateErrorLabel.Text = "";
            this.zipErrorLabel.Text = "";
            this.sexErrorMessageLabel.Text = "";
            this.ssnErrorMessageLabel.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        private void firstNameResultsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
