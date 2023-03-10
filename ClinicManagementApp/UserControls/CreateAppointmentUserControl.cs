using ClinicManagementApp.DAL;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class CreateAppointmentUserControl : UserControl
    {
        private PatientDAL patientDAL;
        public CreateAppointmentUserControl()
        {
            InitializeComponent();
            this.patientDAL = new PatientDAL();
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
    }
}
