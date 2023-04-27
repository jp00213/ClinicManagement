namespace ClinicManagementApp.UserControls
{
    partial class LabTestStatisticUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateEntryPanel = new System.Windows.Forms.Panel();
            this.statusMessageLabel = new System.Windows.Forms.Label();
            this.RunReportbutton = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.labTestReportListView = new System.Windows.Forms.ListView();
            this.testCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timePerformedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allTestTotalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentOfAllTestsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.normalCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abnormalCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age18To29Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age30To39Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.otherAgesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.DateEntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DateEntryPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTestReportListView, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.58695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.41306F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DateEntryPanel
            // 
            this.DateEntryPanel.Controls.Add(this.statusMessageLabel);
            this.DateEntryPanel.Controls.Add(this.RunReportbutton);
            this.DateEntryPanel.Controls.Add(this.endDateTimePicker);
            this.DateEntryPanel.Controls.Add(this.startDateTimePicker);
            this.DateEntryPanel.Controls.Add(this.endDateLabel);
            this.DateEntryPanel.Controls.Add(this.startDateLabel);
            this.DateEntryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateEntryPanel.Location = new System.Drawing.Point(2, 2);
            this.DateEntryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DateEntryPanel.Name = "DateEntryPanel";
            this.DateEntryPanel.Size = new System.Drawing.Size(642, 72);
            this.DateEntryPanel.TabIndex = 0;
            // 
            // statusMessageLabel
            // 
            this.statusMessageLabel.AutoSize = true;
            this.statusMessageLabel.Location = new System.Drawing.Point(261, 15);
            this.statusMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(10, 13);
            this.statusMessageLabel.TabIndex = 5;
            this.statusMessageLabel.Text = "-";
            // 
            // RunReportbutton
            // 
            this.RunReportbutton.Location = new System.Drawing.Point(282, 29);
            this.RunReportbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RunReportbutton.Name = "RunReportbutton";
            this.RunReportbutton.Size = new System.Drawing.Size(75, 23);
            this.RunReportbutton.TabIndex = 2;
            this.RunReportbutton.Text = "Run Report";
            this.RunReportbutton.UseVisualStyleBackColor = true;
            this.RunReportbutton.Click += new System.EventHandler(this.RunReportbutton_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(150, 32);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(27, 32);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(171, 15);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Size = new System.Drawing.Size(56, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(44, 15);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Size = new System.Drawing.Size(59, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date";
            // 
            // labTestReportListView
            // 
            this.labTestReportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.testCodeHeader,
            this.testNameHeader,
            this.timePerformedHeader,
            this.allTestTotalHeader,
            this.percentOfAllTestsHeader,
            this.normalCountHeader,
            this.abnormalCountHeader,
            this.age18To29Header,
            this.age30To39Header,
            this.otherAgesHeader});
            this.labTestReportListView.HideSelection = false;
            this.labTestReportListView.Location = new System.Drawing.Point(2, 78);
            this.labTestReportListView.Margin = new System.Windows.Forms.Padding(2);
            this.labTestReportListView.Name = "labTestReportListView";
            this.labTestReportListView.Size = new System.Drawing.Size(642, 353);
            this.labTestReportListView.TabIndex = 1;
            this.labTestReportListView.UseCompatibleStateImageBehavior = false;
            this.labTestReportListView.View = System.Windows.Forms.View.Details;
            // 
            // testCodeHeader
            // 
            this.testCodeHeader.Text = "Code";
            this.testCodeHeader.Width = 48;
            // 
            // testNameHeader
            // 
            this.testNameHeader.Text = "Test Name";
            this.testNameHeader.Width = 107;
            // 
            // timePerformedHeader
            // 
            this.timePerformedHeader.Text = "# Qualified Test";
            this.timePerformedHeader.Width = 116;
            // 
            // allTestTotalHeader
            // 
            this.allTestTotalHeader.Text = "All Test Total";
            this.allTestTotalHeader.Width = 100;
            // 
            // percentOfAllTestsHeader
            // 
            this.percentOfAllTestsHeader.Text = "% All Tests";
            this.percentOfAllTestsHeader.Width = 89;
            // 
            // normalCountHeader
            // 
            this.normalCountHeader.Text = "Normal Count";
            this.normalCountHeader.Width = 110;
            // 
            // abnormalCountHeader
            // 
            this.abnormalCountHeader.Text = "Abnor. Count";
            this.abnormalCountHeader.Width = 100;
            // 
            // age18To29Header
            // 
            this.age18To29Header.Text = "Age18-29 %";
            this.age18To29Header.Width = 91;
            // 
            // age30To39Header
            // 
            this.age30To39Header.Text = "Age30-39 %";
            this.age30To39Header.Width = 91;
            // 
            // otherAgesHeader
            // 
            this.otherAgesHeader.Text = "Other Ages %";
            this.otherAgesHeader.Width = 103;
            // 
            // LabTestStatisticUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LabTestStatisticUserControl";
            this.Size = new System.Drawing.Size(651, 436);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DateEntryPanel.ResumeLayout(false);
            this.DateEntryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel DateEntryPanel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.ListView labTestReportListView;
        private System.Windows.Forms.ColumnHeader testCodeHeader;
        private System.Windows.Forms.ColumnHeader testNameHeader;
        private System.Windows.Forms.ColumnHeader timePerformedHeader;
        private System.Windows.Forms.ColumnHeader allTestTotalHeader;
        private System.Windows.Forms.ColumnHeader percentOfAllTestsHeader;
        private System.Windows.Forms.ColumnHeader normalCountHeader;
        private System.Windows.Forms.ColumnHeader abnormalCountHeader;
        private System.Windows.Forms.ColumnHeader age18To29Header;
        private System.Windows.Forms.ColumnHeader age30To39Header;
        private System.Windows.Forms.ColumnHeader otherAgesHeader;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button RunReportbutton;
        private System.Windows.Forms.Label statusMessageLabel;
    }
}
