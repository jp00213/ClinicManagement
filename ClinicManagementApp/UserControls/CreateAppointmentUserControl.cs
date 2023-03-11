using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class CreateAppointmentUserControl : UserControl
    {
        private PatientDAL patientDAL;
        private Patient patient;
        public CreateAppointmentUserControl()
        {
            InitializeComponent();
            this.patientDAL = new PatientDAL();
            this.patient = new Patient();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var firstName = this.fNameTextBox.Text;
            var lastName = this.lastNameTextBox.Text;
            var dob = this.dobDateTimePicker.Value;

            if(CheckUserInput(firstName, lastName, dob))
            {
                this.patientDataGridView.DataSource = patientDAL.GetPatientByNameDOB(firstName, lastName, dob);
            }
        }

        private bool CheckUserInput(string firstName, string lastName, DateTime dob)
        {
            if(firstName == null || lastName == null || dob == null)
            {
                return false;
            }

            return true;
        }

        private void PatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientID = patientDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this.patient = this.patientDAL.GetPatientByID(Int32.Parse(patientID));

            if(patient != null)
            {
                patientBindingSource.Add(patient);
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(patient != null)
            {
                this.dateOfBirthDateTimePicker.Value = this.patient.DateOfBirth;
            }
        }
    }
}
