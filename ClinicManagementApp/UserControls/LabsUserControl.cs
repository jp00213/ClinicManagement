using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// Labs User Control
    /// </summary>
    public partial class LabsUserControl : UserControl
    {
        private readonly PatientController _patientController;
        private readonly VisitController _visitController;
        private readonly DoctorController _doctorController;
        private readonly NurseController _nurseController;
        private readonly LabTestController _labTestController;
        private int _visitID;
        private List<PatientVisit> _patients;

        /// <summary>
        /// Constructor for labs user control
        /// </summary>
        public LabsUserControl()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _visitID = -1;
            _visitController = new VisitController(); 
            _doctorController = new DoctorController();
            _nurseController = new NurseController();
            _patients = new List<PatientVisit>();
            _labTestController = new LabTestController();
            setGridComboBoxOptions();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _patients = _patientController.GetPatientsByVisitDate(appointmentDateTimePicker.Value);

            if(_patients.Count > 0)
            {
                patientComboBox.DataSource = _patients;
            }
            else
            {
                MessageBox.Show("No patients with a visit on " + appointmentDateTimePicker.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (_patients.Count > 0)
            {
                _visitID = _patients[patientComboBox.SelectedIndex].VisitID;
                Visit visit = _visitController.GetVisitInformationByVisitID(_visitID);

                patientBindingSource.Clear();
                patientBindingSource.DataSource = _patientController.GetPatientByID(visit.PatientID);

                doctorBindingSource.Clear();
                doctorBindingSource.DataSource = _doctorController.GetDoctorByID(visit.DoctorID);

                nurseBindingSource.Clear();
                nurseBindingSource.DataSource = _nurseController.GetNurseByID(visit.NurseID);

                labDataGridView.DataSource = _labTestController.GetLabTestListByVisitID(_visitID);
            }
        }

        private void setGridComboBoxOptions()
        {
            this.resultIsNormalDataGridViewComboBoxColumn.DataSource = new List<Range>
            {
                new Range {RangeInt = 0, RangeString = "Normal"},
                new Range {RangeInt = 1, RangeString = "Abnormal"}
            };

            this.resultIsNormalDataGridViewComboBoxColumn.DisplayMember = "RangeString";
            this.resultIsNormalDataGridViewComboBoxColumn.ValueMember = "RangeInt";
        }
    }
}
