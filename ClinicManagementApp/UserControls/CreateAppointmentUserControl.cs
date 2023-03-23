using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Drawing;
using System.Globalization;
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
            this.patient = null;
            this.ResetDoctors();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
            var firstName = this.fNameTextBox.Text;
            var lastName = this.lNameTextBox.Text;
            var dob = this.dobDateTimePicker.Value;

            this.patientDataGridView.DataSource = patientController.GetPatientByNameDOB(firstName, lastName, dob);

        }

        private void PatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientID = patientDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this.patient = this.patientController.GetPatientByID(Int32.Parse(patientID));

            if(patient != null)
            {
                patientBindingSource.DataSource = patient;
                patientBindingSource.ResetBindings(true);
                this.saveButton.Enabled = true;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (patient != null)
            {
                this.dateOfBirthDateTimePicker.Value = this.patient.DateOfBirth.Date;
            }
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
            string date = this.appointmentDateTimePicker.Value.ToString("yyyy-MM-dd");
            int doctorID = (int)this.doctorComboBox.SelectedValue;
            this.UpdateTimeOptions(date, doctorID);
        }

        private void UpdateTimeOptions(string date, int doctorID)
        {
            this.timeComboBox.DataSource = null;
            this.timeComboBox.Items.Clear();
            this.timeComboBox.DataSource = this.appointmentController.GetAppointmentTimeOptionsByDateAndDoctor(date, doctorID);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string date = this.appointmentDateTimePicker.Value.ToString("yyyy-MM-dd");
            int doctorID = (int)this.doctorComboBox.SelectedValue;
            string time = this.timeComboBox.Text;
            string reason = this.reasonTextBox.Text;
            Console.Write(reason);
            int patientID = Int32.Parse(this.patientIDTextBox.Text);

            string format = "yyyy-MM-dd HH:mm:ss";
            string dateTimeString = date + " " + time;
            DateTime dateTime = DateTime.ParseExact(dateTimeString, format, CultureInfo.InvariantCulture);

            if (string.IsNullOrEmpty(date) || time == null || string.IsNullOrEmpty(reason) || doctorID < 0)
            {
                this.messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Please complete all: date, doctor, time, and reason.";
            }
            else
            {
                Appointment appointment = new Appointment(-1, patientID, doctorID, dateTime, reason);
                int success = this.appointmentController.AddAppointment(appointment);
                
                if (success >= 0)
                {
                    MessageBox.Show("Appointment has been added.");
                    this.ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.fNameTextBox.Text = "";
            this.lNameTextBox.Text = "";
            this.appointmentDateTimePicker.Value = DateTime.Now;
            this.dobDateTimePicker.Value = DateTime.Now;
            this.SearchButton_Click(null, null);
            this.dateOfBirthDateTimePicker.Value = DateTime.Now;

            this.patient = null;
            this.patientBindingSource.DataSource = this.patientController.GetPatientByNameDOB("", "", DateTime.Now);
            this.reasonTextBox.Text = "";
            this.saveButton.Enabled = false;
            this.ResetDoctors();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
            this.ResetForm();
        }

        private void ResetDoctors()
        {
            try 
            { 
                this.doctorComboBox.DataSource = this.doctorController.GetDoctors();
                this.doctorComboBox.DisplayMember = "FullName";
                this.doctorComboBox.ValueMember = "DoctorID";
                string date = this.appointmentDateTimePicker.Value.ToString("yyyy-MM-dd");
                int doctorID = (int)this.doctorComboBox.SelectedValue;
                this.UpdateTimeOptions(date, doctorID);
            }
            catch
            {
                MessageBox.Show("No doctors available for appointments.");
            }
        }
    }
}
