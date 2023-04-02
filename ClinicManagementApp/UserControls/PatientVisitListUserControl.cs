using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// this class manages usercontrol for viewing patient visit information
    /// </summary>
    public partial class PatientVisitListUserControl : UserControl
    {
        /// <summary>
        /// create constructors
        /// </summary>
        public PatientVisitListUserControl()
        {
            InitializeComponent();
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
