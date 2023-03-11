using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class CreateAppointmentUserControl : UserControl
    {
        private PatientController patientController;
        private AppointmentController appointmentController;
        private DoctorController doctorController;
        private Patient patient;
        public CreateAppointmentUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.patient = new Patient();
            this.doctorComboBox.DataSource = this.doctorController.GetDoctors();
            this.doctorComboBox.DisplayMember = "FullName";
            this.doctorComboBox.ValueMember = "DoctorID";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var firstName = this.fNameTextBox.Text;
            var lastName = this.lastNameTextBox.Text;
            var dob = this.dobDateTimePicker.Value;

            if(CheckUserInput(firstName, lastName, dob))
            {
                this.patientDataGridView.DataSource = patientController.GetPatientByNameDOB(firstName, lastName, dob);
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
            this.patient = this.patientController.GetPatientByID(Int32.Parse(patientID));

            if(patient != null)
            {
                patientBindingSource.DataSource = patient;
                patientBindingSource.ResetBindings(true);
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(patient != null)
            {
                this.dateOfBirthDateTimePicker.Value = this.patient.DateOfBirth.Date;
            }
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string date = this.appointmentDateTimePicker.Value.ToString("yyyy-MM-dd");
            int doctorID = (int)this.doctorComboBox.SelectedValue;
            this.timeComboBox.DataSource = null;
            this.timeComboBox.Items.Clear();
            this.timeComboBox.DataSource = this.appointmentController.GetAppointmentTimeOptionsByDateAndDoctor(date, doctorID);
        }

        private void DoctorComboBox_ValueMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
