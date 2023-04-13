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
            this.HasVisitInfoBeenEnteredForAppointmentID();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int appointmentID = this._appointment.AppointmentID;
            int nurseID = 4;
            DateTime visitDateTime = DateTime.Now;
            Decimal feet = this.feetNumericUpDown.Value;
            Decimal inches = this.inchesNumericUpDown.Value;
            Decimal height = this.CalculateHeight(feet, inches);
            Decimal weight1 = Decimal.Parse(this.weightTextBox.Text.Trim());
            Decimal weight = Decimal.Parse(this.weightTextBox.Text.Trim());
            Decimal bodyTemperature = Decimal.Parse(this.temperatureTextBox.Text.Trim());

            int diastolicBloodPressure;
            int.TryParse(this.diastolicTextBox.Text.Trim(), out diastolicBloodPressure);

            int systolicBloodPressure;
            int.TryParse(this.systolicTextBox.Text.Trim(), out systolicBloodPressure);

            int pulse; 
            int.TryParse(this.pulseTextBox.Text.Trim(), out pulse);

            var symptoms = this.symptomsTextBox.Text.Trim();
            var initialDiagnosis = this.initialDiagnosisTextbox.Text.Trim();
            var finalDiagnosis = this.finalDiagnosisTextBox.Text.Trim();

            if (appointmentID <= 0 || this._appointment == null || nurseID <= 0 || height < 10 || height > 250 || weight < 0 || weight > 800 || diastolicBloodPressure > 370 || diastolicBloodPressure < 40 || systolicBloodPressure > 360 || systolicBloodPressure < 20 || bodyTemperature > 115 || bodyTemperature < 78 || pulse > 400 || pulse < 55 || string.IsNullOrEmpty(symptoms) || string.IsNullOrEmpty(initialDiagnosis))
            {
                this.ShowInvalidErrorMessages();
            } else
            {
                if (this.ConfirmNotesAndLabs() == DialogResult.Yes)
                {
                    Visit visit = new Visit(-1, appointmentID, nurseID, visitDateTime, height, weight, diastolicBloodPressure, systolicBloodPressure, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis);
                    int success = this._visitController.AddVisit(visit);
                    this.OrderLabs(success);
                    this.ResetForm();
                }
            }
        }

        private Decimal CalculateHeight(Decimal feet, Decimal inches)
        {
            Decimal feetToCM = feet * (Decimal)30.48;
            Decimal inchesToCM = inches * (Decimal)2.54;
            return feetToCM + inchesToCM;
        }

        private void OrderLabs(int visitID)
        {
            List<LabTest> labs = new List<LabTest>();
            List<string> testNames = new List<string>();

            foreach (LabTest lab in labsListBox.SelectedItems)
            {
                labs.Add(lab);
            }

            foreach (LabTest lab in labs)
            {
                LabTest currentLab = new LabTest(visitID, lab.TestCode, DateTime.Now, "PENDING", lab.TestName, 0, DateTime.Now);
                this._labController.AddLabTest(currentLab);
            }
            MessageBox.Show("Visit notes saved and labs have been ordered!", "Visit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult ConfirmNotesAndLabs()
        {
            List<LabTest> labs = new List<LabTest>();
            List<string> testNames = new List<string>();

            foreach (LabTest lab in labsListBox.SelectedItems)
            {
                string name = "\t\u2022   " + "Test code: " + lab.TestCode.ToString() + "  |  " + lab.TestName.ToString();
                testNames.Add(name);
                
            }
            var message = string.Join(Environment.NewLine, testNames);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to complete the visit notes and order the following test(s) for " + this._patient.FullName + ":\n \n" + message, "Pending Notes and Lab Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return dialogResult;
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

            if (this._appointment.AppointmentID <= 0 || this._appointment == null)
            {
                this.generalErrorLabel.Text = "Please select a patient appointment from the list above to begin the visit.";
                this.generalErrorLabel.ForeColor = Color.Red;
            }

            if (this.CalculateHeight(feetNumericUpDown.Value, inchesNumericUpDown.Value) < 10 || this.CalculateHeight(feetNumericUpDown.Value, inchesNumericUpDown.Value) > 250)
            {
                this.heightErrorLabel.Text = "Please enter a valid height.";
                this.heightErrorLabel.ForeColor = Color.Red;
            }

            if (Decimal.Parse(this.weightTextBox.Text.Trim()) < 0 || Decimal.Parse(this.weightTextBox.Text.Trim()) > 800 || string.IsNullOrEmpty(this.weightTextBox.Text))
            {
                this.weightErrorLabel.Text = "Please enter a valid weight.";
                this.weightErrorLabel.ForeColor = Color.Red;
            }

            if (int.Parse(this.diastolicTextBox.Text.Trim()) < 40 || int.Parse(this.diastolicTextBox.Text.Trim()) > 370 || string.IsNullOrEmpty(this.diastolicTextBox.Text))
            {
                this.diastolicBloodPressureErrorLabel.Text = "Please enter a valid diastolic blood pressure.";
                this.diastolicBloodPressureErrorLabel.ForeColor = Color.Red;
            }

            if (int.Parse(this.systolicTextBox.Text.Trim()) < 20 || int.Parse(this.systolicTextBox.Text.Trim()) > 360 || string.IsNullOrEmpty(this.systolicTextBox.Text) )
            {
                this.systolicErrorLabel.Text = "Please enter a valid systolic blood pressure.";
                this.systolicErrorLabel.ForeColor = Color.Red;
            }

            if (Decimal.Parse(this.temperatureTextBox.Text.Trim()) < 78 || Decimal.Parse(this.temperatureTextBox.Text.Trim()) > 115 || string.IsNullOrEmpty(this.temperatureTextBox.Text))
            {
                this.bodyTemperatureErrorLabel.Text = "Please enter a valid temperature.";
                this.bodyTemperatureErrorLabel.ForeColor = Color.Red; 
            }

            if (int.Parse(this.pulseTextBox.Text.Trim()) < 55 || int.Parse(this.pulseTextBox.Text.Trim()) > 400 || string.IsNullOrEmpty(this.pulseTextBox.Text))
            {
                this.pulseErrorLabel.Text = "Please enter a valid pulse.";
                this.pulseErrorLabel.ForeColor = Color.Red; 
            }

            if (string.IsNullOrEmpty(this.symptomsTextBox.Text.Trim()))
            {
                this.symptomsErrorLabel.Text = "Please enter some symptoms.";
                this.symptomsErrorLabel.ForeColor = Color.Red;
            }

            if (string.IsNullOrEmpty(this.initialDiagnosisTextbox.Text.Trim()))
            {
                this.initialDiagnosisErrorLabel.Text = "Please enter an initial diagnosis.";
                this.initialDiagnosisLabel.ForeColor= Color.Red;
            }

        }

        private void HideInvalidErrorMessages()
        {
            this.generalErrorLabel.Text = "";
            this.heightErrorLabel.Text = "";
            this.weightErrorLabel.Text = "";
            this.diastolicBloodPressureErrorLabel.Text = "";
            this.systolicErrorLabel.Text = "";
            this.bodyTemperatureErrorLabel.Text = "";
            this.pulseErrorLabel.Text = "";
            this.symptomsErrorLabel.Text = "";
            this.initialDiagnosisErrorLabel.Text = "";
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

            this.feetNumericUpDown.Value = 1;
            this.inchesNumericUpDown.Value = 0;
            this.weightTextBox.Text = "";
            this.diastolicTextBox.Text = "";
            this.systolicTextBox.Text = "";
            this.symptomsTextBox.Text = "";
            this.initialDiagnosisTextbox.Text = "";
            this.finalDiagnosisTextBox.Text = "";
            this.pulseTextBox.Text = "";
            this.temperatureTextBox.Text = "";

            this.labsListBox.ClearSelected();

            this.saveButton.Enabled = false;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            this.HideInvalidErrorMessages();
        }

        private void CheckInputIsDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HideInvalidErrorMessages();
        }

        private void HasVisitInfoBeenEnteredForAppointmentID()
        {
            List<Visit> visits = this._visitController.GetVisitInformationListByPatientID(this._patient.PatientID);
            
            foreach (Visit visit in visits)
            {
                if(visit.AppointmentID == this._appointment.AppointmentID)
                {          
                    MessageBox.Show("Visit details have already been entered for this patient and cannot be changed. Please choose another patient from the list.", "Visit Already Documented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.saveButton.Enabled = false;
                }
               
            }
           
        }
    }
}
