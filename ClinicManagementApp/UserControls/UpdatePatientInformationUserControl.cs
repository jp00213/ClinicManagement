using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class UpdatePatientInformationUserControl : UserControl
    {
        private PatientController _patientController;
        private Patient _patient;
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

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
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
    }
}
