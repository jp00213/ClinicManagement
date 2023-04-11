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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagementApp.UserControls
{
    public partial class DocumentVisitUserControl : UserControl
    {
        private PatientController _patientController;
        private DoctorController _doctorController;
        private AppointmentController _appointmentController;
        private VisitController _visitController;
        private LabTestController _labController;
        private Patient _patient;
        private Appointment _appointment;
        public DocumentVisitUserControl()
        {
            InitializeComponent();
            this._patientController = new PatientController();
            this._doctorController = new DoctorController();
            this._appointmentController= new AppointmentController();
            this._visitController = new VisitController();
            this._labController = new LabTestController();

            this._patient = null;
            this._appointment = null;
            this.labsListBox.DataSource = _labController.GetLabTests();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DateTime appointmentDate = this.appointmentDateTimePicker.Value.Date;
            this.patientDataGridView.DataSource = _patientController.GetPatientByAppointmentDate(appointmentDate);
        }

        private void patientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var patientID = patientDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            this._patient = this._patientController.GetPatientByID(Int32.Parse(patientID));

            if (_patient != null)
            {
                patientBindingSource.DataSource = _patient;
                patientBindingSource.ResetBindings(true);
                this.saveButton.Enabled = true;
            }
 
            int activePatientID = this._patient.PatientID;
            DateTime appointmentDate = this.appointmentDateTimePicker.Value.Date;
            this._appointment = this._appointmentController.GetAppointmentByPatientIDAndDate(activePatientID, appointmentDate);
            this.GetDoctorInfoForAppointment(this._appointment.AppointmentID);
            
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int appointmentID = this._appointment.AppointmentID;
            int nurseID = 1;
            DateTime visitDateTime = DateTime.Now;
            Decimal height = this.CalculateHeight(this.feetNumericUpDown.Value, this.inchesNumericUpDown.Value);
            Decimal weight = Decimal.Parse(this.weightTextBox.Text);
            int diastolicBloodPressure = int.Parse(this.diastolicTextBox.Text);
            int systolicBloodPressure = int.Parse(this.systolicTextBox.Text);
            Decimal bodyTemperature = Decimal.Parse(this.temperatureTextBox.Text);
            int pulse = int.Parse(this.pulseTextBox.Text);
            var symptoms = this.symptomsTextBox.Text;
            var initialDiagnosis = this.initialDiagnosisTextbox.Text;
            var finalDiagnosis = this.finalDiagnosisTextBox.Text;

            if (appointmentID <= 0 || nurseID <= 0 || height < 10 || height > 250 || weight < 0 || weight > 800 || diastolicBloodPressure > 370 || diastolicBloodPressure < 40 || systolicBloodPressure > 360 || systolicBloodPressure < 20 || bodyTemperature > 115 || bodyTemperature < 78 || pulse > 400 || pulse < 55 || string.IsNullOrEmpty(symptoms) || string.IsNullOrEmpty(initialDiagnosis) || string.IsNullOrEmpty(finalDiagnosis))
            {
                this.ShowInvalidErrorMessages();
            } else
            {
                Visit visit = new Visit(-1, appointmentID, nurseID, visitDateTime, height, weight, diastolicBloodPressure, systolicBloodPressure, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis);
                int success = this._visitController.AddVisit(visit);
                if (success > 0)
                    {
                        MessageBox.Show("Appointment notes successfully saved!", "Appointment Notes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private Decimal CalculateHeight(Decimal feet, Decimal inches)
        {
            Decimal feetToCM = feet * (Decimal)30.48;
            Decimal inchesToCM = inches * (Decimal)2.54;
            return feetToCM + inchesToCM;
        }

        private void orderLabsButton_Click(object sender, EventArgs e)
        {
            List<LabTest> labs = new List<LabTest>();
            List<String> testNames = new List<String>();
            string[] labNames = testNames.ToArray();
            int paul = 0;
            foreach ( LabTest lab in labsListBox.SelectedItems)
            {
                /*labs.Add(lab);
                testNames.Add(lab.TestName);*/
                paul++;
                
            }
            MessageBox.Show(paul.ToString());
        }

        private void GetDoctorInfoForAppointment(int appointmentID)
        {
            List<Doctor> doctors = this._doctorController.GetDoctorAndSpecialtyByAppointmentID(appointmentID);
            this.activeDoctorNameLabel.Text = doctors[0].FullName;
            this.activeDoctorIDLabel.Text = doctors[0].DoctorID.ToString();

            List<string> specialties = new List<string>();
            foreach (Doctor doctor in doctors)
            {
                specialties.Add(doctor.Speciality.ToString());
            }
            this.activeSpecialtyLabel.Text = string.Join(", ", specialties);
        }

        private void ShowInvalidErrorMessages()
        {

        }

        private void HideInvalidErrorMessages()
        {

        }

        private void ResetForm()
        {
            this.appointmentDateTimePicker.Value = DateTime.Now;
            this.selectButton_Click(null, null);

            this._patient = null;
            this.patientBindingSource.DataSource = this._patientController.GetPatientByNameDOB("", "", DateTime.Now);

            activeDoctorNameLabel.Text = "";
            activeDoctorIDLabel.Text = "";
            activeSpecialtyLabel.Text = "";

            this.saveButton.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            this.HideInvalidErrorMessages();
        }
    }
}
