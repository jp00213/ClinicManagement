using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class AdministratorAddNurseUserControl : UserControl
    {
        private NurseController _nurseController;

        public AdministratorAddNurseUserControl()
        {
            InitializeComponent();
            this._nurseController = new NurseController();
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

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
