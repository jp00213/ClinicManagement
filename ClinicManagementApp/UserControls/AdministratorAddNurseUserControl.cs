﻿using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// Add Nurse User Control
    /// </summary>
    public partial class AdministratorAddNurseUserControl : UserControl
    {
        private NurseController _nurseController;
        private AccountController _accountController;

        /// <summary>
        /// Constructor for user control
        /// </summary>
        public AdministratorAddNurseUserControl()
        {
            InitializeComponent();
            this._nurseController = new NurseController();
            this._accountController = new AccountController();
            sexComboBox.Items.Insert(0, "--select--");
            sexComboBox.Items.Insert(1, "M");
            sexComboBox.Items.Insert(2, "F");
            sexComboBox.SelectedIndex = 0;
        }

        private void ResetInputFields()
        {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            phoneTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateComboBox.SelectedItem = null;
            zipTextBox.Clear();
            sexComboBox.SelectedItem = null;
            ssnTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void addNurseButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextBox.Text.Trim();
            string firstName = this.firstNameTextBox.Text.Trim();
            DateTime dateOfBirth = this.dateOfBirthDateTimePicker.Value;
            string phone = this.phoneTextBox.Text.Trim();
            string address = this.addressTextBox.Text.Trim();
            string city = this.cityTextBox.Text.Trim();
            string state = this.stateComboBox.Text;
            string zip = this.zipTextBox.Text.Trim();
            string sex = this.sexComboBox.Text.Trim();
            string ssn = this.ssnTextBox.Text.Trim();
            string username = this.usernameTextBox.Text.Trim();
            string password = this.passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || dateOfBirth > DateTime.Now || string.IsNullOrEmpty(address)
                || address.Length < 5 || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || state.Length != 2 || !IsValidZipCode(zip)
                || !IsPhoneNumberValid(phone) || !IsSexValid(sex) || !IsSSNValid(ssn) || !IsUsernameValid(username) || !IsPasswordValid(password))
            {
                this.ShowInvalidErrorMessage();
            }
            else
            {
                Person person = new Person(lastName, firstName, dateOfBirth, address, city, state, zip, phone, sex, ssn);
                if (this._nurseController.AddNurse(person, username, password))
                {
                    MessageBox.Show("Nurse successfully created!", "Nurse Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetInputFields();
                }
                else
                {
                    MessageBox.Show("Nurse was not created");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            this.HideInvalidErrorMessages();
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

            if (!IsSexValid(sexComboBox.Text))
            {
                this.sexErrorMessageLabel.Text = "Please enter M or F.";
                this.sexErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsSSNValid(ssnTextBox.Text))
            {
                this.ssnErrorMessageLabel.Text = "Please enter a valid 9 digit SSN, numbers only.";
                this.ssnErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsUsernameValid(usernameTextBox.Text))
            {
                this.usernameErrorMessageLabel.Text = "Username already taken.";
                this.usernameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                this.usernameErrorMessageLabel.Text = "Enter a valid username.";
                this.usernameErrorMessageLabel.ForeColor = Color.Red;
            }

            if (!IsPasswordValid(passwordTextBox.Text))
            {
                this.passwordErrorMessageLabel.Text = "Enter a valid password.";
                this.passwordErrorMessageLabel.ForeColor = Color.Red;
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

        private bool IsUsernameValid(string username)
        {
            bool validUsername = true;
            if (this._accountController.IsUsernameUnique(username))
            {
                validUsername = true;
            } else
            {
                validUsername= false;
            }
            return validUsername;
        }

        private bool IsPasswordValid(string password)
        {
            bool validPassword = true;
            string passwordRegEx = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[\w!@#$%^&*()_+]{8,}$";
            if (!Regex.Match(password, passwordRegEx).Success)
            {
                validPassword = false;
            }
            return validPassword;
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
            this.usernameErrorMessageLabel.Text = "";
            this.passwordErrorMessageLabel.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

    }
}
