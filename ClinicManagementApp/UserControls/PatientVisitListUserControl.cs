using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// this class manages usercontrol for viewing patient visit information
    /// </summary>
    public partial class PatientVisitListUserControl : UserControl
    {
        private readonly VisitController _visitController;
        private readonly PatientController _patientController;
        private readonly LabTestController _labTestController;
        private Person thePatient;
        private Visit theVisit;

        /// <summary>
        /// create constructors
        /// </summary>
        public PatientVisitListUserControl()
        {
            InitializeComponent();
            this._visitController= new VisitController();
            this._patientController= new PatientController();
            this._labTestController= new LabTestController();
            this.thePatient= new Person();
            this.theVisit= new Visit();
            this.SetBeginningDiagnosisButtons();
        }

        private void SetBeginningDiagnosisButtons()
        {
            this.saveFinalDiagnosisButton.Hide();
            this.initialDiagnosisTextBox.Enabled = false;
            this.finalDiagnosisTextBox.Enabled = false;
            this.cancelFinalEditButton.Hide();
            this.initialDiagnosisTextBox.Text = "";
            this.finalDiagnosisTextBox.Text = "";
            this.HideTheSaveFinalDiagnosisButton();
        }

        private void currentVisitIDLabel_TextChanged(object sender, System.EventArgs e)
        {
            this.HideAllDiagnosisButtons();
            this.SetVisitVitalDetails();
            this.LoadLabTestListView();
            this.EnableFinalDiagnosisButtonsIfNotEntered();
        }

        private void HideTheSaveFinalDiagnosisButton()
        {
            if (CheckIfFinalDiagnosisHasBeenEntered() == true)
            {
                saveFinalDiagnosisButton.Hide();
            }
        }

        private void HideAllDiagnosisButtons()
        {
            if (currentVisitIDLabel.Text != "--")
            {
                SetBeginningDiagnosisButtons();
            }
        }

        private void EnableFinalDiagnosisButtonsIfNotEntered()
        {
            if (!CheckIfFinalDiagnosisHasBeenEntered())
            {
                this.finalDiagnosisTextBox.Enabled = true;
                this.saveFinalDiagnosisButton.Show();
                this.cancelFinalEditButton.Show();
            }
        }

        private bool CheckIfFinalDiagnosisHasBeenEntered()
        {
            if (currentVisitIDLabel.Text != "--")
            {
                Visit theVisit = this._visitController.GetVisitInformationByVisitID(int.Parse(this.currentVisitIDLabel.Text));
                string finalVisitDiagnosisText = theVisit.FinalDiagnoses.ToString();

                if (finalVisitDiagnosisText == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// setter patientID
        /// </summary>
        public string ID
        {
            set { patientIDTextBox.Text = value; }
        }

        private void LoadVisitComboBox()
        {
            messageTextLabel.Text = "";
            visitListComboBox.DataSource = null;
            visitListComboBox.DataSource = this._visitController.GetVisitInformationListByPatientID(int.Parse(patientIDTextBox.Text));
            visitListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            visitListComboBox.DisplayMember = "visitSummary";
            visitListComboBox.ValueMember = "visitID";
            visitListComboBox.SelectedIndex = 0;
            setInitialVisitIDTextBoxIfVisitFound();
        }

        private int GetVisitListCount()
        {
            return this._visitController.GetVisitInformationListByPatientID(int.Parse(patientIDTextBox.Text)).Count;
        }

        private void setInitialVisitIDTextBoxIfVisitFound()
        {
            if (this.GetVisitListCount() > 0)
            {
                this.currentVisitIDLabel.Text = visitListComboBox.SelectedValue.ToString();
                this.messageTextLabel.Text = "";
            }
            else
            {
                this.currentVisitIDLabel.Text = "";
                this.messageTextLabel.Text = "Patient has no visit record.";
            }
        }

        private void patientIDTextBox_TextChanged(object sender, System.EventArgs e)
        {
            this.messageTextLabel.Text = "";

            if (this.GetVisitListCount() > 0)
            {
                this.LoadVisitComboBox();
            }
            else
            {
                this.messageTextLabel.Text = "Patient has no visit record.";
            }

            if (patientIDTextBox.Text == "0")
            {
                this.messageTextLabel.Text = "";
                this.visitListComboBox.DataSource = null;
                this.currentVisitIDLabel.Text = "--";
            }

            this.SetPatientInformation();
        }

        private void visitListComboBox_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            currentVisitIDLabel.Text = visitListComboBox.SelectedValue.ToString();
        }

        private void SetPatientInformation()
        {
            if (this.patientIDTextBox.Text != "0")
            {
                this.thePatient = this._patientController.GetPatientByID(int.Parse(this.patientIDTextBox.Text));
                this.patientNameValueLabel.Text = this.thePatient.LastName + ", " + this.thePatient.FirstName;
                this.dobValueLabel.Text = this.thePatient.DateOfBirth.ToShortDateString();
                this.phoneValueLabel.Text = Regex.Replace(this.thePatient.Phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
            else
            {
                this.ClearAllDataDisplay();
                this.ClearVitalsDisplay();
            }
        }

        private void SetInitialDiagnosesText()
        {
            if (currentVisitIDLabel.Text != "--")
            {
                this.theVisit = this._visitController.GetVisitInformationByVisitID(int.Parse(this.currentVisitIDLabel.Text));
                this.initialDiagnosisTextBox.Text = this.theVisit.InitialDiagnoses.ToString();
            }
        }

        private void SetFinalDiagnosesText()
        {
            if (currentVisitIDLabel.Text != "--")
            {
                this.theVisit = this._visitController.GetVisitInformationByVisitID(int.Parse(this.currentVisitIDLabel.Text));
                this.finalDiagnosisTextBox.Text = this.theVisit.FinalDiagnoses.ToString();
            }
        }

        private void SetVisitVitalDetails()
        {
            if (currentVisitIDLabel.Text != "--")
            {
                this.theVisit = this._visitController.GetVisitInformationByVisitID(int.Parse(this.currentVisitIDLabel.Text));
                this.enteredByValueLabel.Text = this.theVisit.NurseLastName + ", " + this.theVisit.NurseFirstName;
                this.heightValuelabel.Text = this.theVisit.HeightFormatted.ToString();
                this.weightValueLabel.Text = this.theVisit.Weight.ToString();
                this.bpValueLabel.Text = this.theVisit.BloodPressureSystolic.ToString() + "/" + this.theVisit.BloodPressureDiastolic.ToString();
                this.tempValueLabel.Text = this.theVisit.BodyTemperature.ToString();
                this.pulseValueLabel.Text = this.theVisit.Pulse.ToString();
                this.symptomsValueTextBox.Text = this.theVisit.Symptoms.ToString();
                this.initialDiagnosisTextBox.Text = this.theVisit.InitialDiagnoses.ToString();
                this.finalDiagnosisTextBox.Text = this.theVisit.FinalDiagnoses.ToString();
            }
            else
            {
                this.ClearVitalsDisplay();
            }
        }

        private void ClearAllDataDisplay()
        {
            this.patientNameValueLabel.Text = "";
            this.dobValueLabel.Text = "";
            this.phoneValueLabel.Text = "";
            this.updateMessage.Text = "";
        }

        private void ClearVitalsDisplay()
        {
            this.enteredByValueLabel.Text = "--";
            this.heightValuelabel.Text = "--";
            this.weightValueLabel.Text = "--";
            this.bpValueLabel.Text = "--";
            this.tempValueLabel.Text = "--";
            this.pulseValueLabel.Text = "--";
            this.symptomsValueTextBox.Text = "--";
            this.updateMessage.Text= "";
            this.SetBeginningDiagnosisButtons();
            HideAllDiagnosisButtons();
        }

        private void LoadLabTestListView()
        {
            labResultListView.Items.Clear();
            if (this.currentVisitIDLabel.Text != "--")
            {
                List<LabTest> labTestList;
                labTestList = this._labTestController.GetLabTestListByVisitID(int.Parse(this.currentVisitIDLabel.Text));

                if (labTestList.Count > 0)
                {
                    labResultListView.Items.Clear();
                    LabTest theTest;
                    for (int i = 0; i < labTestList.Count; i++)
                    {
                        theTest = labTestList[i];
                        labResultListView.Items.Add(theTest.TestName.ToString());
                        labResultListView.Items[i].SubItems.Add(theTest.Result.ToString());
                        labResultListView.Items[i].SubItems.Add(theTest.TestDate.ToShortDateString());

                        string normalOrAbnormal = "";
                        if (theTest.ResultIsNormal.ToString() == "1")
                        {

                            normalOrAbnormal = "Normal";
                        }
                        else if (theTest.ResultIsNormal.ToString() == "0")
                        {
                            normalOrAbnormal = "Abnormal";
                        }
                        else
                        {
                            normalOrAbnormal = "Not Ready";
                        }
                        labResultListView.Items[i].SubItems.Add(normalOrAbnormal);

                    }
                }
            }
        }

        private void cancelFinalEditButton_Click(object sender, System.EventArgs e)
        {
            this.finalDiagnosisTextBox.Text = "";
            this.finalDiagnosisTextBox.Enabled = true;
        }

        private void saveFinalDiagnosisButton_Click(object sender, System.EventArgs e)
        {
            this.SetFinalDiagnosis();
        }

        private void SetFinalDiagnosis()
        {
            string warningMessage = "Once the final diagnosis is entered, no more change is allowed. Do you want to continue?";
            string title = "Final Diagnosis Warning!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(warningMessage, title, buttons);

            if (result == DialogResult.Yes)
            {
                bool updatedResult;
                Visit visitData = new Visit();

                if (finalDiagnosisTextBox.Text.Length <= 5)
                {
                    this.updateMessage.Text = "The text must be over 5 letters.";
                }
                else if (finalDiagnosisTextBox.Text.Length > 500)
                {
                    this.updateMessage.Text = "The text must be less than 500 letters.";
                }
                else
                {
                    try
                    {
                        visitData.VisitID = int.Parse(currentVisitIDLabel.Text);
                        visitData.FinalDiagnoses = finalDiagnosisTextBox.Text;

                        updatedResult = this._visitController.EnterFinalDiagnosis(visitData);

                        if (updatedResult == true)
                        {
                            finalDiagnosisTextBox.Enabled = false;
                            this.updateMessage.Text = "Final diagnosis has been updated.";
                            this.disableTheAddTestButton();
                        }
                        else
                        {
                            this.updateMessage.Text = "Update Failed.";
                        }
                    }
                    catch (Exception)
                    {
                        this.updateMessage.Text = "Update Failed.";
                        return;
                    }
                }
            }
            else
            {
                this.updateMessage.Text = "Cancelled.";
            }
        }

        private void finalDiagnosisTextBox_TextChanged(object sender, EventArgs e)
        {
            this.updateMessage.Text = "";
        }

        private void disableTheAddTestButton()
        {
            if (CheckIfFinalDiagnosisHasBeenEntered())
            {
                this.cancelFinalEditButton.Hide();
                this.HideTheSaveFinalDiagnosisButton();
            }
        }
    }
}
