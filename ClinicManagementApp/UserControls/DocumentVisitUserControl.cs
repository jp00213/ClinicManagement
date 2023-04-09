using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class DocumentVisitUserControl : UserControl
    {
        private PatientController _patientController;
        private AppointmentController _appointmentController;
        private VisitController _visitController;
        private Patient _patient;
        public DocumentVisitUserControl()
        {
            InitializeComponent();
            this._patientController = new PatientController();
            this._appointmentController= new AppointmentController();
            this._visitController = new VisitController();
            this._patient = null;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DateTime appointmentDate = this.appointmentDateTimePicker.Value;
            this.patientDataGridView.DataSource = _patientController.GetPatientByAppointmentDate(appointmentDate);
        }

        private void patientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientID = patientDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this._patient = this._patientController.GetPatientByID(Int32.Parse(patientID));

            int patientIDd = this._patient.PatientID;
            DateTime appointmentDate = this.appointmentDateTimePicker.Value;
            Appointment appointment = this._appointmentController.GetAppointmentByPatientIDAndDate(patientIDd, appointmentDate);
            this.phoneLabel.Text = appointment.AppointmentID.ToString();

            if (_patient != null)
            {
                patientBindingSource.DataSource = _patient;
                patientBindingSource.ResetBindings(true);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            
            
            
            int appointmentID = 8;
            int nurseID = 1;
            DateTime visitDateTime = DateTime.Now;
            Decimal height = this.CalculateHeight(this.feetNumericUpDown.Value, this.inchesNumericUpDown.Value);
            Decimal weight = Decimal.Parse(this.weightTextBox.Text);
            int dbp = int.Parse(this.diastolicTextBox.Text);
            int sbp = int.Parse(this.systolicTextBox.Text);
            Decimal bodyTemp = Decimal.Parse(this.temperatureTextBox.Text);
            int pulse = int.Parse(this.pulseTextBox.Text);
            var symptoms = this.symptomsTextBox.Text;
            var initialDiagnosis = this.initialDiagnosisTextbox.Text;
            var finalDiagnosis = this.finalDiagnosisTextBox.Text;

            Visit visit = new Visit(-1, appointmentID, nurseID, visitDateTime, height, weight, dbp, sbp, bodyTemp, pulse, symptoms, initialDiagnosis, finalDiagnosis);
            int success = this._visitController.AddVisit(visit);
            if (success > 0)
            {
                MessageBox.Show("Appointment notes successfully saved!", "Appointment Notes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            
        }

        private Decimal CalculateHeight(Decimal feet, Decimal inches)
        {
            Decimal feetToCM = feet * (Decimal)30.48;
            Decimal inchesToCM = inches * (Decimal)2.54;
            return feetToCM + inchesToCM;
        }

        
    }
}
