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
    public partial class RegisterPatientUserControl : UserControl
    {
        private PatientController _patientController;

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
            stateTextBox.Clear();
            zipTextBox.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string lastName = this.lastNameTextBox.Text;
            string firstName = this.firstNameTextBox.Text;
            DateTime dateOfBirth = this.dateOfBirthDateTimePicker.Value;
            string phone = this.phoneTextBox.Text;
            string address = this.addressTextBox.Text;
            string city = this.cityTextBox.Text;
            string state = this.stateTextBox.Text;
            string zip = this.zipTextBox.Text;

            Person person = new Person(lastName, firstName, dateOfBirth, address, city, state, zip, phone);
            int success = this._patientController.AddPatient(person);
            if (success >= 0)
            {
                MessageBox.Show("Patient successfully created!", "Patient Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetInputFields();
            }
            
        }
    }
}
