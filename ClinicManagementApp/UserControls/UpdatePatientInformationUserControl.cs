using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ClinicManagementApp.UserControls
{
    public partial class UpdatePatientInformationUserControl : UserControl
    {
        private PatientController _patientController;
        private Patient _patient;
        private AppointmentController _appointmentController;
        /// <summary>
        /// Initializes the User Control
        /// </summary>
        public UpdatePatientInformationUserControl()
        {
            InitializeComponent();
            this._patientController= new PatientController();
            this._appointmentController = new AppointmentController();
            this._patient = null;
            sexComboBox.Items.Insert(0, "--select--");
            sexComboBox.Items.Insert(1, "M");
            sexComboBox.Items.Insert(2, "F");
            sexComboBox.SelectedIndex = 0;
            this.updatePatientButton.Enabled = false;
            this.deletePatientButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string firstName = this.firstNameTextBox.Text;
            string lastName = this.lastNameTextBox.Text;
            DateTime dob = this.dateOfBirthDateTimePicker.Value;

            this.patientSearchDataGridView.DataSource = _patientController.GetPatientByNameDOB(firstName, lastName, dob);

            this.ResetIndividualInfo();
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
                this.deletePatientButton.Enabled = true;
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
            string sex = this.sexComboBox.Text.Trim();
            string ssn = this.sSNTextBox.Text.Trim();
            Patient oldPatient = _patient;


            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dateOfBirth > DateTime.Now ||string.IsNullOrEmpty(address) 
                || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || !IsValidZipCode(zip) 
                || !IsPhoneNumberValid(phone) || !IsSexValid(sex) || !IsSSNValid(ssn))
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
                } else
                {
                    MessageBox.Show("Patient not updated");
                }
            }

        }

        private void clearPatientButton_Click(object sender, EventArgs e)
        {
            this.ResetIndividualInfo();
            this.HideInvalidErrorMessages();
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
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

            this.ResetIndividualInfo();
        }

        private void ResetIndividualInfo()
        {
            this._patient = null;
            this.patientBindingSource.DataSource = this._patientController.GetPatientByNameDOB("", "", DateTime.Now);
            this.updatePatientButton.Enabled = false;
            this.deletePatientButton.Enabled = false;
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

            if (!IsSexValid(sexComboBox.Text))
            {
                this.sexErrorMessageLabel.Text = "Please enter M or F.";
                this.sexErrorMessageLabel.ForeColor = Color.Red;
            }
            
            if (!IsSSNValid(sSNTextBox.Text))
            {
                this.ssnErrorMessageLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
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
            string ssnRegEx = @"^[0-9]{9}$";
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

        private bool IsSexValid(string sex)
        {
            bool validSex = true;
            if (String.Equals(sex, "M") || String.Equals(sex, "F"))
            {
                validSex = true;
            }
            else
            {
                validSex = false;
            }
            return validSex;
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

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            List<Appointment> currentAppointments = this._appointmentController.GetAppointmentsByID_NowOn(this._patient.PatientID);
            List<Appointment> pastAppointments = this._appointmentController.GetAppointmentsByID_Past(this._patient.PatientID);
            bool haveAppointment = (currentAppointments.Count + pastAppointments.Count) > 0;
            if (!haveAppointment)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Pending Patient Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bool deleteSuccess = this._patientController.DeletePatientByPatientID(this._patient);
                    if (deleteSuccess)
                    {
                        MessageBox.Show("Patient successfully deleted.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Patient not deleted. Please verify this person does not serve other roles in the clinic before attempting to delete.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                    
            } else
            {
                MessageBox.Show("Appointment information is associated with this patient. The patient cannot be deleted at this time.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
