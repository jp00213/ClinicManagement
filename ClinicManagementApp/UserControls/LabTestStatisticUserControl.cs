using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// this class manages usercontrol for viewing patient lab test statistic information
    /// </summary>
    public partial class LabTestStatisticUserControl : UserControl
    {

        private LabTestController _labTestController;

        /// <summary>
        /// create constructors
        /// </summary>
        public LabTestStatisticUserControl()
        {
            InitializeComponent();
            this._labTestController = new LabTestController();
        }

        private void SetDefaultSetting()
        {
            startDateTimePicker.CustomFormat = "dd-MM-yyyy";
            endDateTimePicker.CustomFormat = "dd-MM-yyyy";
            statusMessageLabel.Text = string.Empty;
        }

        private void RunReportbutton_Click(object sender, EventArgs e)
        {
            DateTime startIn = startDateTimePicker.Value;
            DateTime endIn = endDateTimePicker.Value;

            if (startIn <= endIn)
            {
                labTestReportListView.Items.Clear();
                statusMessageLabel.Text = ".";
                this.LoadReport(startIn, endIn);
            }
            else
            {
                labTestReportListView.Items.Clear();
                statusMessageLabel.Text = "Start date cannot later than end date.";
            }
        }

        private void LoadReport(DateTime startDate, DateTime endDate)
        {
            List<LabTest> labTestReportList = this._labTestController.GetMostPerformedTestsDuringDates(startDate, endDate);

            if (labTestReportList.Count > 0)
            {
                statusMessageLabel.Text = string.Empty;
                labTestReportListView.Items.Clear();
                LabTest currentLabTest;

                for (int i = 0; i < labTestReportList.Count; i++)
                {
                    currentLabTest = labTestReportList[i];
                    labTestReportListView.Items.Add(currentLabTest.TestCode.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.TestName);
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.TimesPerformed.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.AllTestTotal.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.PercentOfAllTests.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.NormalCount.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.AbnormalCount.ToString());
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.Age18To29);
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.Age30To39);
                    labTestReportListView.Items[i].SubItems.Add(currentLabTest.OtherAges);
                }
            }
            else
            {
                statusMessageLabel.Text = "No Record Found.";
            }
        }
    }
}
