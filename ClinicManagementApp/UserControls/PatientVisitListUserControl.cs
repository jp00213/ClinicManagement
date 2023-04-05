using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
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

        }


        /// <summary>
        /// setter patientID
        /// </summary>
        public string ID
        {
            set { patientIDTextBox.Text = value; }
        }


    }
}
