using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// Register Patient User Control
    /// </summary>
    public partial class RegisterPatientUserControl : UserControl
    {
        private PatientController _patientController;

        /// <summary>
        /// Constructor for RegisterPatientUserControl
        /// </summary>
        public RegisterPatientUserControl()
        {
            InitializeComponent();
            this._patientController= new PatientController();
        }

        /// <summary>
        /// Clears all textboxes on page
        /// </summary>
        public void ResetInputFields()
        {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            phoneTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateComboBox.SelectedItem = null;
            zipTextBox.Clear();
            sexTextBox.Clear();
            ssnTextBox.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            this.HideInvalidErrorMessages();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextBox.Text.Trim();
            string firstName = this.firstNameTextBox.Text.Trim();
            DateTime dateOfBirth = this.dateOfBirthDateTimePicker.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexTextBox.Text.Trim();
            string ssn = this.ssnTextBox.Text.Trim();

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dateOfBirth > DateTime.Now || string.IsNullOrEmpty(address) 
                || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || state.Length != 2 || !IsValidZipCode(zip) 
                || !IsPhoneNumberValid(phone) || !IsSexValid(sex) || !IsSSNValid(ssn))
            {
                this.ShowInvalidErrorMessage();
            } else
            {
                Person person = new Person(lastName, firstName, dateOfBirth, address, city, state, zip, phone, sex, ssn);
                if (this._patientController.AddPatient(person))
                {
                    MessageBox.Show("Patient successfully created!", "Patient Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetInputFields();
                } else
                {
                    MessageBox.Show("Patient was not created");
                }
            }            
        }

        private void ShowInvalidErrorMessage()
        {
            if (string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                this.lastNameErrorMessageLabel.Text = "Please enter your last name.";
                this.lastNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                this.firstNameErrorMessageLabel.Text = "Please enter your first name.";
                this.firstNameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (dateOfBirthDateTimePicker.Value > DateTime.Now)
            {
                this.DOBErrorLabel.Text = "DOB cannot be in the future.";
                this.DOBErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) || addressTextBox.Text.Length < 5)
            {
                this.addressErrorMessageLabel.Text = "Please enter your full street address.";
                this.addressErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text) || string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                this.cityErrorMessageLabel.Text = "Please enter your city.";
                this.cityErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                this.stateErrorMessageLabel.Text = "Please select your state abbreviation.";
                this.stateErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsValidZipCode(zipTextBox.Text))
            {
                this.zipErrorMessageLabel.Text = "Please enter a valid zipcode.";
                this.zipErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsPhoneNumberValid(phoneTextBox.Text))
            {
                this.phoneErrorMessageLabel.Text = "Please enter your 10 digit phone number, numbers only.";
                this.phoneErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsSexValid(sexTextBox.Text))
            {
                this.sexErrorMessageLabel.Text = "Please enter M or F.";
                this.sexErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsSSNValid(ssnTextBox.Text))
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
            } else if (!Regex.Match(ssn, ssnRegEx).Success)
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
            } else
            {
                validSex = false;
            }
            return validSex;
        }

        private void HideInvalidErrorMessages()
        {
            this.lastNameErrorMessageLabel.Text = "";
            this.firstNameErrorMessageLabel.Text = "";
            this.DOBErrorLabel.Text = "";
            this.addressErrorMessageLabel.Text = "";
            this.phoneErrorMessageLabel.Text = "";
            this.cityErrorMessageLabel.Text = "";
            this.stateErrorMessageLabel.Text = "";
            this.zipErrorMessageLabel.Text = "";
            this.sexErrorMessageLabel.Text = "";
            this.ssnErrorMessageLabel.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        
    }
}
