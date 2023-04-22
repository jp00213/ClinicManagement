using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class UpdateNurseUserControl : UserControl
    {
        private readonly NurseController _nurseController;
        private Nurse _nurse;
        public UpdateNurseUserControl()
        {
            InitializeComponent();
            _nurseController = new NurseController();
            _nurse = new Nurse();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            var firstName = this.searchFirstNameTextBox.Text;
            var lastName = this.searchLastNameTextBox.Text;
            List<Nurse> nurseList = _nurseController.GetNurseByName(firstName, lastName);

            this.nurseDataGridView.DataSource = nurseList;

            if (nurseList.Count == 0)
            {
                messageLabel.Text = "No nurses found.";
            }
        }

        private void NurseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var nurseID = nurseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                _nurse = this._nurseController.GetNurseByID(Int32.Parse(nurseID));

                if (_nurse != null)
                {
                    nurseBindingSource.DataSource = _nurse;
                    nurseBindingSource.ResetBindings(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            if(_nurse != null && _nurse.FullName.Length > 0 && CheckUserInput())
            {
                this.updateMessageLabel.Text = "";

                Nurse updatedNurse = new Nurse()
                {
                    RecordID = _nurse.RecordID,
                    NurseID = _nurse.NurseID,
                    FirstName = this.firstNameTextBox.Text,
                    LastName = this.lastNameTextBox.Text,
                    SSN = this.sSNTextBox.Text,
                    Username = this.usernameTextBox.Text,
                    AddressStreet = this.addressStreetTextBox.Text,
                    City = this.cityTextBox.Text,
                    State = this.stateComboBox.Text,
                    Zip = this.zipTextBox.Text,
                    Phone = this.phoneTextBox.Text,
                    Sex = this.sexComboBox.Text,
                    DateOfBirth = this.dateOfBirthDateTimePicker.Value,
                    IsActive = Int32.Parse(this.isActiveComboBox.Text)
                };

                bool updateSuccess = _nurseController.UpdateNurse(updatedNurse);

                if (updateSuccess)
                {
                    this.updateMessageLabel.ForeColor = Color.Green;
                    this.updateMessageLabel.Text = "Nurse has been updated.";
                }
                else
                {
                    this.updateMessageLabel.ForeColor= Color.Red;
                    this.updateMessageLabel.Text = "Nurse not been updated.";
                }
            } 
            else
            {
                this.updateMessageLabel.Text = "Nurse is not in database. Please add nurse first.";
            }
        }

        private bool CheckUserInput()
        {
            bool canUpdate = true;
            this.updateMessageLabel.ForeColor = Color.Red;

            if (lastNameTextBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "Last name cannot be blank.";
                canUpdate = false;
            } 
            else if(firstNameTextBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "First name cannot be blank.";
                canUpdate = false;
            }
            else if(dateOfBirthDateTimePicker.Value == DateTime.MinValue)
            {
                this.updateMessageLabel.Text = "Date of birth cannot be blank.";
                canUpdate = false;
            }
            else if (usernameTextBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "Username cannot be blank.";
                canUpdate = false;
            }
            else if(addressStreetTextBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "Street Address cannot be blank.";
                canUpdate = false;
            }
            else if(cityTextBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "City cannot be blank.";
                canUpdate = false;
            }
            else if(stateComboBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "State cannot be blank.";
                canUpdate = false;
            }
            else if(zipTextBox.Text.Length == 0 || zipTextBox.Text.Length > 10)
            {
                this.updateMessageLabel.Text = "Zip code cannot be blank and has maximum 10 characters.";
                canUpdate = false;
            }
            else if(sexComboBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "Sex cannot be blank.";
                canUpdate = false;
            }
            else if(phoneTextBox.Text.Length == 0 || phoneTextBox.Text.Length > 10)
            {
                this.updateMessageLabel.Text = "Phone number cannot be blank. Max characters is 10.";
                canUpdate = false;
            } else if(isActiveComboBox.Text.Length == 0)
            {
                this.updateMessageLabel.Text = "Active Status cannot be blank.";
                canUpdate = false;
            }
            return canUpdate;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var nurse = new Nurse();
            nurseBindingSource.DataSource = nurse;
            nurseBindingSource.ResetBindings(true);
            stateComboBox.SelectedIndex = 0;
            sexComboBox.SelectedIndex = 0;
            isActiveComboBox.SelectedIndex = 0;
            this.updateMessageLabel.Text = "";
            this.messageLabel.Text = "";
        }
    }
}
