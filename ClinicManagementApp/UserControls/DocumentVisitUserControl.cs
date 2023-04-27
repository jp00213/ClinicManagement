using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// Document Visit User Control
    /// </summary>
    public partial class DocumentVisitUserControl : UserControl
    {
        private PatientController _patientController;
        private DoctorController _doctorController;
        private NurseController _nurseController;
        private AppointmentController _appointmentController;
        private VisitController _visitController;
        private LabTestController _labController;
        private Patient _patient;
        private Appointment _appointment;
       

        /// <summary>
        /// Creates the document visit user control
        /// </summary>
        public DocumentVisitUserControl()
        {
            InitializeComponent();
            this._patientController = new PatientController();
            this._doctorController = new DoctorController();
            this._nurseController = new NurseController();
            this._appointmentController = new AppointmentController();
            this._visitController = new VisitController();
            this._labController = new LabTestController();
            

            this._patient = null;
            this._appointment = null;
            this.labsListBox.DataSource = _labController.GetLabTests();
            this.labsListBox.ClearSelected();

            this.saveButton.Enabled = false;
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
            this.GetNurseForAppointment();
            this.HasVisitInfoBeenEnteredForAppointmentID();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ResetForm();    
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int appointmentID = this._appointment.AppointmentID;
                if (appointmentID <= 0)
                {
                    MessageBox.Show("Please select a patient from the list.", "No Appointment Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.ShowInvalidErrorMessages();
                int nurseID = this.GetNurseForAppointment();
                DateTime visitDateTime = DateTime.Now;
                Decimal feet = this.feetNumericUpDown.Value;
                Decimal inches = this.inchesNumericUpDown.Value;
                Decimal height = this.CalculateHeight(feet, inches);

                Decimal weight;
                this.CheckForParseErrors(Decimal.TryParse(this.weightTextBox.Text.Trim(), out weight));

                Decimal bodyTemperature;
                this.CheckForParseErrors(Decimal.TryParse(this.temperatureTextBox.Text.Trim(), out bodyTemperature));

                int diastolicBloodPressure;
                this.CheckForParseErrors(int.TryParse(this.diastolicTextBox.Text.Trim(), out diastolicBloodPressure));

                int systolicBloodPressure;
                this.CheckForParseErrors(int.TryParse(this.systolicTextBox.Text.Trim(), out systolicBloodPressure));

                int pulse;
                this.CheckForParseErrors(int.TryParse(this.pulseTextBox.Text.Trim(), out pulse));

                var symptoms = this.symptomsTextBox.Text.Trim();
                var initialDiagnosis = this.initialDiagnosisTextbox.Text.Trim();
                var finalDiagnosis = this.finalDiagnosisTextBox.Text.Trim();

                if (height < 10 || height > 250 || weight < 0 || weight > 800 || diastolicBloodPressure > 370 || diastolicBloodPressure < 40 || systolicBloodPressure > 360 || systolicBloodPressure < 20 || bodyTemperature > 115 || bodyTemperature < 78 || pulse > 400 || pulse < 55 || string.IsNullOrEmpty(symptoms) || string.IsNullOrEmpty(initialDiagnosis))
                {
                    this.ShowInvalidErrorMessages();
                }
                else
                {
                    if (this.ConfirmNotesAndLabs() == DialogResult.Yes)
                    {
                        Visit visit = new Visit(-1, appointmentID, nurseID, visitDateTime, height, weight, diastolicBloodPressure, systolicBloodPressure, bodyTemperature, pulse, symptoms, initialDiagnosis, finalDiagnosis);
                        int success = this._visitController.AddVisit(visit);
                        if (success > 0)
                        {
                            this.OrderLabsAndCompleteVisit(success);
                            this.ResetForm();
                        }
                    }
                }
            } catch(System.FormatException)
            {
                MessageBox.Show("Please input valid visit details for the patient, then press 'Save Appointment'.", "Visit Details Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckForParseErrors(bool parseable)
        {
            if (!parseable)
            {
                this.ShowInvalidErrorMessages();
            }
        }

        private Decimal CalculateHeight(Decimal feet, Decimal inches)
        {
            Decimal feetToIn = feet * (Decimal)12.00;
            Decimal inchesInput = inches;
            return feetToIn + inchesInput;
        }

        private void OrderLabsAndCompleteVisit(int visitID)
        {
            List<LabTest> labs = new List<LabTest>();
            List<string> testNames = new List<string>();

            foreach (LabTest lab in labsListBox.SelectedItems)
            {
                labs.Add(lab);
            }
            
            if (labs.Count > 0)
            {
                foreach (LabTest lab in labs)
                {
                    LabTest currentLab = new LabTest(visitID, lab.TestCode, new DateTime(1900, 1, 1), "", lab.TestName, 0, DateTime.Now);
                    this._labController.AddLabTest(currentLab);
                }
                MessageBox.Show("Visit notes saved and labs have been ordered!", "Visit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Visit notes successfully saved!", "Visit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private DialogResult ConfirmNotesAndLabs()
        {
            List<LabTest> labs = new List<LabTest>();
            List<string> testNames = new List<string>();
            DialogResult dialogResult;
            
            foreach (LabTest lab in labsListBox.SelectedItems)
            {
                string name = "\t\u2022   " + "Test code: " + lab.TestCode.ToString() + "  |  " + lab.TestName.ToString();
                testNames.Add(name);
            }

            if (testNames.Count > 0)
            {
                var message = string.Join(Environment.NewLine, testNames);
                dialogResult = MessageBox.Show("Are you sure you want to complete the visit notes and order the following test(s) for " + this._patient.FullName + ":\n \n" + message, "Pending Notes and Lab Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            } else
            {
                dialogResult = MessageBox.Show("Are you sure you want to complete the visit notes for " + this._patient.FullName +" with no lab orders?", "Pending Notes and Lab Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

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

        private int GetNurseForAppointment()
        {
            try
            {
                string nurseUserName = NurseController.GetUsername();
                Nurse nurse = this._nurseController.GetNurseByUsername(nurseUserName);
                this.activeNurseNameLabel.Text = nurse.FullName;
                this.activeNurseIDLabel.Text = nurse.NurseID.ToString();
                return nurse.NurseID;
            } catch(Exception)
            {
                MessageBox.Show("You must be an active nurse in our system to input visit notes. Please logout and log back in with valid credentials.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.saveButton.Enabled = false;
                return -1;
            }
             
        }

        private void ShowInvalidErrorMessages()
        {

            if (this._appointment.AppointmentID <= 0 || this._appointment == null)
            {
                this.generalErrorLabel.Text = "Please select a patient appointment from the list above to begin the visit.";
                this.generalErrorLabel.ForeColor = Color.Red;
            }

            if (this.CalculateHeight(feetNumericUpDown.Value, inchesNumericUpDown.Value) < 12 || this.CalculateHeight(feetNumericUpDown.Value, inchesNumericUpDown.Value) > 100)
            {
                this.heightErrorLabel.Text = "Please enter a valid height.";
                this.heightErrorLabel.ForeColor = Color.Red;
            }

            if (!Decimal.TryParse(this.weightTextBox.Text.Trim(), out _) || Decimal.Parse(this.weightTextBox.Text.Trim()) < 0 || Decimal.Parse(this.weightTextBox.Text.Trim()) > 800 || string.IsNullOrEmpty(this.weightTextBox.Text))
            {
                this.weightErrorLabel.Text = "Please enter a valid weight. Ex: 167.3";
                this.weightErrorLabel.ForeColor = Color.Red;
            }

            if (!int.TryParse(this.diastolicTextBox.Text.Trim(), out _) || int.Parse(this.diastolicTextBox.Text.Trim()) < 40 || int.Parse(this.diastolicTextBox.Text.Trim()) > 370 || string.IsNullOrEmpty(this.diastolicTextBox.Text))
            {
                this.diastolicBloodPressureErrorLabel.Text = "Please enter a whole number for diastolic BP. Ex: 120";
                this.diastolicBloodPressureErrorLabel.ForeColor = Color.Red;
            }

            if (!int.TryParse(this.systolicTextBox.Text.Trim(), out _) || int.Parse(this.systolicTextBox.Text.Trim()) < 20 || int.Parse(this.systolicTextBox.Text.Trim()) > 360 || string.IsNullOrEmpty(this.systolicTextBox.Text) )
            {
                this.systolicErrorLabel.Text = "Please enter a whole number for systolic BP. Ex: 80";
                this.systolicErrorLabel.ForeColor = Color.Red;
            }

            if (!Decimal.TryParse(this.temperatureTextBox.Text.Trim(), out _) || Decimal.Parse(this.temperatureTextBox.Text.Trim()) < 78 || Decimal.Parse(this.temperatureTextBox.Text.Trim()) > 115 || string.IsNullOrEmpty(this.temperatureTextBox.Text))
            {
                this.bodyTemperatureErrorLabel.Text = "Please enter a valid temperature. Ex: 98.6";
                this.bodyTemperatureErrorLabel.ForeColor = Color.Red; 
            }

            if (!int.TryParse(this.pulseTextBox.Text.Trim(), out _) || int.Parse(this.pulseTextBox.Text.Trim()) < 55 || int.Parse(this.pulseTextBox.Text.Trim()) > 400 || string.IsNullOrEmpty(this.pulseTextBox.Text))
            {
                this.pulseErrorLabel.Text = "Please enter a whole number for pulse. Ex: 98";
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
                this.initialDiagnosisErrorLabel.ForeColor= Color.Red;
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
            DialogResult clearForm = MessageBox.Show("Are you sure you want to clear the form? Any unsaved changes will be lost.", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (clearForm == DialogResult.Yes)
            {
                this.ResetForm();
                this.HideInvalidErrorMessages();
            }
            
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
                if (visit.AppointmentID == this._appointment.AppointmentID)
                {
                    MessageBox.Show("Visit details have already been entered for this patient and cannot be changed. Please choose another patient from the list.", "Visit Already Documented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.saveButton.Enabled = false;
                }

            }
        }
    }
}
