namespace ClinicManagementApp.UserControls
{
    partial class PatientVisitListUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.visitListComboBox = new System.Windows.Forms.ComboBox();
            this.visitID_Label = new System.Windows.Forms.Label();
            this.currentVisitIDLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labsOrderedLabel = new System.Windows.Forms.Label();
            this.patientInformationPanel = new System.Windows.Forms.Panel();
            this.labOrdersPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labResultListView = new System.Windows.Forms.ListView();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.patientNameValueLabel = new System.Windows.Forms.Label();
            this.dobValueLabel = new System.Windows.Forms.Label();
            this.phoneValueLabel = new System.Windows.Forms.Label();
            this.enteredByLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.bpLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.enterDiagnosisLabel = new System.Windows.Forms.Label();
            this.enteredByValueLabel = new System.Windows.Forms.Label();
            this.heightValuelabel = new System.Windows.Forms.Label();
            this.weightValueLabel = new System.Windows.Forms.Label();
            this.bpValueLabel = new System.Windows.Forms.Label();
            this.tempValueLabel = new System.Windows.Forms.Label();
            this.pulseValueLabel = new System.Windows.Forms.Label();
            this.symptomsValueTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.updateMessage = new System.Windows.Forms.Label();
            this.orderAdditionalTestButton = new System.Windows.Forms.Button();
            this.cancelFinalEditButton = new System.Windows.Forms.Button();
            this.saveFinalDiagnosisButton = new System.Windows.Forms.Button();
            this.messageTextLabel = new System.Windows.Forms.Label();
            this.testNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePerformedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.normalNotNormalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.patientInformationPanel.SuspendLayout();
            this.labOrdersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visit List";
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(83, 0);
            this.patientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(57, 13);
            this.patientIDLabel.TabIndex = 2;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientIDTextBox.Location = new System.Drawing.Point(136, 0);
            this.patientIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(46, 13);
            this.patientIDTextBox.TabIndex = 3;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.patientIDTextBox_TextChanged);
            // 
            // visitListComboBox
            // 
            this.visitListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitListComboBox.FormattingEnabled = true;
            this.visitListComboBox.Location = new System.Drawing.Point(186, 2);
            this.visitListComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.visitListComboBox.Name = "visitListComboBox";
            this.visitListComboBox.Size = new System.Drawing.Size(244, 21);
            this.visitListComboBox.TabIndex = 6;
            this.visitListComboBox.SelectionChangeCommitted += new System.EventHandler(this.visitListComboBox_SelectionChangeCommitted);
            // 
            // visitID_Label
            // 
            this.visitID_Label.AutoSize = true;
            this.visitID_Label.Location = new System.Drawing.Point(434, 5);
            this.visitID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitID_Label.Name = "visitID_Label";
            this.visitID_Label.Size = new System.Drawing.Size(43, 13);
            this.visitID_Label.TabIndex = 8;
            this.visitID_Label.Text = "Visit ID:";
            // 
            // currentVisitIDLabel
            // 
            this.currentVisitIDLabel.AutoSize = true;
            this.currentVisitIDLabel.Location = new System.Drawing.Point(481, 5);
            this.currentVisitIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentVisitIDLabel.Name = "currentVisitIDLabel";
            this.currentVisitIDLabel.Size = new System.Drawing.Size(13, 13);
            this.currentVisitIDLabel.TabIndex = 9;
            this.currentVisitIDLabel.Text = "--";
            this.currentVisitIDLabel.TextChanged += new System.EventHandler(this.currentVisitIDLabel_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.patientInformationPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.26316F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 228);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labOrdersPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(201, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.69697F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 231);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // labsOrderedLabel
            // 
            this.labsOrderedLabel.AutoSize = true;
            this.labsOrderedLabel.Location = new System.Drawing.Point(205, 24);
            this.labsOrderedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labsOrderedLabel.Name = "labsOrderedLabel";
            this.labsOrderedLabel.Size = new System.Drawing.Size(74, 13);
            this.labsOrderedLabel.TabIndex = 12;
            this.labsOrderedLabel.Text = "Labs Ordered:";
            // 
            // patientInformationPanel
            // 
            this.patientInformationPanel.Controls.Add(this.phoneValueLabel);
            this.patientInformationPanel.Controls.Add(this.dobValueLabel);
            this.patientInformationPanel.Controls.Add(this.patientNameValueLabel);
            this.patientInformationPanel.Controls.Add(this.phoneLabel);
            this.patientInformationPanel.Controls.Add(this.dobLabel);
            this.patientInformationPanel.Controls.Add(this.patientNameLabel);
            this.patientInformationPanel.Controls.Add(this.patientInformationLabel);
            this.patientInformationPanel.Location = new System.Drawing.Point(2, 2);
            this.patientInformationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.patientInformationPanel.Name = "patientInformationPanel";
            this.patientInformationPanel.Size = new System.Drawing.Size(196, 41);
            this.patientInformationPanel.TabIndex = 0;
            // 
            // labOrdersPanel
            // 
            this.labOrdersPanel.Controls.Add(this.labResultListView);
            this.labOrdersPanel.Location = new System.Drawing.Point(2, 2);
            this.labOrdersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.labOrdersPanel.Name = "labOrdersPanel";
            this.labOrdersPanel.Size = new System.Drawing.Size(407, 64);
            this.labOrdersPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderAdditionalTestButton);
            this.panel1.Controls.Add(this.symptomsValueTextBox);
            this.panel1.Controls.Add(this.pulseValueLabel);
            this.panel1.Controls.Add(this.tempValueLabel);
            this.panel1.Controls.Add(this.bpValueLabel);
            this.panel1.Controls.Add(this.weightValueLabel);
            this.panel1.Controls.Add(this.heightValuelabel);
            this.panel1.Controls.Add(this.enteredByValueLabel);
            this.panel1.Controls.Add(this.pulseLabel);
            this.panel1.Controls.Add(this.tempLabel);
            this.panel1.Controls.Add(this.bpLabel);
            this.panel1.Controls.Add(this.symptomsLabel);
            this.panel1.Controls.Add(this.weightLabel);
            this.panel1.Controls.Add(this.heightLabel);
            this.panel1.Controls.Add(this.enteredByLabel);
            this.panel1.Location = new System.Drawing.Point(2, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 179);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveFinalDiagnosisButton);
            this.panel2.Controls.Add(this.cancelFinalEditButton);
            this.panel2.Controls.Add(this.updateMessage);
            this.panel2.Controls.Add(this.finalDiagnosisTextBox);
            this.panel2.Controls.Add(this.initialDiagnosisTextBox);
            this.panel2.Controls.Add(this.enterDiagnosisLabel);
            this.panel2.Controls.Add(this.diagnosisLabel);
            this.panel2.Location = new System.Drawing.Point(2, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 120);
            this.panel2.TabIndex = 1;
            // 
            // labResultListView
            // 
            this.labResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.testNameHeader,
            this.resultHeader,
            this.datePerformedHeader,
            this.normalNotNormalHeader});
            this.labResultListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.labResultListView.HideSelection = false;
            this.labResultListView.Location = new System.Drawing.Point(0, 0);
            this.labResultListView.Margin = new System.Windows.Forms.Padding(2);
            this.labResultListView.Name = "labResultListView";
            this.labResultListView.Size = new System.Drawing.Size(352, 64);
            this.labResultListView.TabIndex = 0;
            this.labResultListView.UseCompatibleStateImageBehavior = false;
            this.labResultListView.View = System.Windows.Forms.View.Details;
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.patientInformationLabel.Location = new System.Drawing.Point(46, 0);
            this.patientInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientInformationLabel.Name = "patientInformationLabel";
            this.patientInformationLabel.Size = new System.Drawing.Size(114, 13);
            this.patientInformationLabel.TabIndex = 0;
            this.patientInformationLabel.Text = "Patient Information";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.patientNameLabel.Location = new System.Drawing.Point(0, 13);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(38, 13);
            this.patientNameLabel.TabIndex = 3;
            this.patientNameLabel.Text = "Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dobLabel.Location = new System.Drawing.Point(0, 26);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(33, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "DOB:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.phoneLabel.Location = new System.Drawing.Point(93, 26);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone:";
            // 
            // patientNameValueLabel
            // 
            this.patientNameValueLabel.AutoSize = true;
            this.patientNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.patientNameValueLabel.Location = new System.Drawing.Point(25, 13);
            this.patientNameValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameValueLabel.Name = "patientNameValueLabel";
            this.patientNameValueLabel.Size = new System.Drawing.Size(13, 13);
            this.patientNameValueLabel.TabIndex = 4;
            this.patientNameValueLabel.Text = "--";
            // 
            // dobValueLabel
            // 
            this.dobValueLabel.AutoSize = true;
            this.dobValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dobValueLabel.Location = new System.Drawing.Point(25, 26);
            this.dobValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobValueLabel.Name = "dobValueLabel";
            this.dobValueLabel.Size = new System.Drawing.Size(13, 13);
            this.dobValueLabel.TabIndex = 8;
            this.dobValueLabel.Text = "--";
            // 
            // phoneValueLabel
            // 
            this.phoneValueLabel.AutoSize = true;
            this.phoneValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.phoneValueLabel.Location = new System.Drawing.Point(128, 26);
            this.phoneValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneValueLabel.Name = "phoneValueLabel";
            this.phoneValueLabel.Size = new System.Drawing.Size(13, 13);
            this.phoneValueLabel.TabIndex = 10;
            this.phoneValueLabel.Text = "--";
            // 
            // enteredByLabel
            // 
            this.enteredByLabel.AutoSize = true;
            this.enteredByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.enteredByLabel.Location = new System.Drawing.Point(0, 0);
            this.enteredByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enteredByLabel.Name = "enteredByLabel";
            this.enteredByLabel.Size = new System.Drawing.Size(62, 13);
            this.enteredByLabel.TabIndex = 1;
            this.enteredByLabel.Text = "Entered By:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.heightLabel.Location = new System.Drawing.Point(0, 13);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.weightLabel.Location = new System.Drawing.Point(0, 26);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight:";
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.symptomsLabel.Location = new System.Drawing.Point(0, 39);
            this.symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(58, 13);
            this.symptomsLabel.TabIndex = 12;
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // bpLabel
            // 
            this.bpLabel.AutoSize = true;
            this.bpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bpLabel.Location = new System.Drawing.Point(128, 0);
            this.bpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bpLabel.Name = "bpLabel";
            this.bpLabel.Size = new System.Drawing.Size(24, 13);
            this.bpLabel.TabIndex = 4;
            this.bpLabel.Text = "BP:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tempLabel.Location = new System.Drawing.Point(126, 13);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(37, 13);
            this.tempLabel.TabIndex = 5;
            this.tempLabel.Text = "Temp:";
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.pulseLabel.Location = new System.Drawing.Point(128, 26);
            this.pulseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(36, 13);
            this.pulseLabel.TabIndex = 6;
            this.pulseLabel.Text = "Pulse:";
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.diagnosisLabel.Location = new System.Drawing.Point(2, 13);
            this.diagnosisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(83, 13);
            this.diagnosisLabel.TabIndex = 0;
            this.diagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // enterDiagnosisLabel
            // 
            this.enterDiagnosisLabel.AutoSize = true;
            this.enterDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enterDiagnosisLabel.Location = new System.Drawing.Point(2, 49);
            this.enterDiagnosisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterDiagnosisLabel.Name = "enterDiagnosisLabel";
            this.enterDiagnosisLabel.Size = new System.Drawing.Size(81, 13);
            this.enterDiagnosisLabel.TabIndex = 2;
            this.enterDiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // enteredByValueLabel
            // 
            this.enteredByValueLabel.AutoSize = true;
            this.enteredByValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.enteredByValueLabel.Location = new System.Drawing.Point(49, 0);
            this.enteredByValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enteredByValueLabel.Name = "enteredByValueLabel";
            this.enteredByValueLabel.Size = new System.Drawing.Size(13, 13);
            this.enteredByValueLabel.TabIndex = 13;
            this.enteredByValueLabel.Text = "--";
            // 
            // heightValuelabel
            // 
            this.heightValuelabel.AutoSize = true;
            this.heightValuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.heightValuelabel.Location = new System.Drawing.Point(49, 13);
            this.heightValuelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightValuelabel.Name = "heightValuelabel";
            this.heightValuelabel.Size = new System.Drawing.Size(13, 13);
            this.heightValuelabel.TabIndex = 14;
            this.heightValuelabel.Text = "--";
            // 
            // weightValueLabel
            // 
            this.weightValueLabel.AutoSize = true;
            this.weightValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.weightValueLabel.Location = new System.Drawing.Point(49, 26);
            this.weightValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightValueLabel.Name = "weightValueLabel";
            this.weightValueLabel.Size = new System.Drawing.Size(13, 13);
            this.weightValueLabel.TabIndex = 15;
            this.weightValueLabel.Text = "--";
            // 
            // bpValueLabel
            // 
            this.bpValueLabel.AutoSize = true;
            this.bpValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bpValueLabel.Location = new System.Drawing.Point(156, 0);
            this.bpValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bpValueLabel.Name = "bpValueLabel";
            this.bpValueLabel.Size = new System.Drawing.Size(13, 13);
            this.bpValueLabel.TabIndex = 16;
            this.bpValueLabel.Text = "--";
            // 
            // tempValueLabel
            // 
            this.tempValueLabel.AutoSize = true;
            this.tempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tempValueLabel.Location = new System.Drawing.Point(156, 11);
            this.tempValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempValueLabel.Name = "tempValueLabel";
            this.tempValueLabel.Size = new System.Drawing.Size(13, 13);
            this.tempValueLabel.TabIndex = 17;
            this.tempValueLabel.Text = "--";
            // 
            // pulseValueLabel
            // 
            this.pulseValueLabel.AutoSize = true;
            this.pulseValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.pulseValueLabel.Location = new System.Drawing.Point(156, 26);
            this.pulseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pulseValueLabel.Name = "pulseValueLabel";
            this.pulseValueLabel.Size = new System.Drawing.Size(13, 13);
            this.pulseValueLabel.TabIndex = 18;
            this.pulseValueLabel.Text = "--";
            // 
            // symptomsValueTextBox
            // 
            this.symptomsValueTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.symptomsValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.symptomsValueTextBox.Location = new System.Drawing.Point(5, 54);
            this.symptomsValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.symptomsValueTextBox.Multiline = true;
            this.symptomsValueTextBox.Name = "symptomsValueTextBox";
            this.symptomsValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.symptomsValueTextBox.Size = new System.Drawing.Size(188, 62);
            this.symptomsValueTextBox.TabIndex = 19;
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.initialDiagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(63, 10);
            this.initialDiagnosisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.initialDiagnosisTextBox.Multiline = true;
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(289, 37);
            this.initialDiagnosisTextBox.TabIndex = 1;
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.finalDiagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(63, 49);
            this.finalDiagnosisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(289, 39);
            this.finalDiagnosisTextBox.TabIndex = 4;
            this.finalDiagnosisTextBox.TextChanged += new System.EventHandler(this.finalDiagnosisTextBox_TextChanged);
            // 
            // updateMessage
            // 
            this.updateMessage.AutoSize = true;
            this.updateMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateMessage.Location = new System.Drawing.Point(5, 107);
            this.updateMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateMessage.Name = "updateMessage";
            this.updateMessage.Size = new System.Drawing.Size(13, 13);
            this.updateMessage.TabIndex = 13;
            this.updateMessage.Text = "--";
            // 
            // orderAdditionalTestButton
            // 
            this.orderAdditionalTestButton.Location = new System.Drawing.Point(40, 120);
            this.orderAdditionalTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.orderAdditionalTestButton.Name = "orderAdditionalTestButton";
            this.orderAdditionalTestButton.Size = new System.Drawing.Size(119, 22);
            this.orderAdditionalTestButton.TabIndex = 6;
            this.orderAdditionalTestButton.Text = "Order Additional Tests";
            this.orderAdditionalTestButton.UseVisualStyleBackColor = true;
            // 
            // cancelFinalEditButton
            // 
            this.cancelFinalEditButton.Location = new System.Drawing.Point(109, 89);
            this.cancelFinalEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelFinalEditButton.Name = "cancelFinalEditButton";
            this.cancelFinalEditButton.Size = new System.Drawing.Size(118, 22);
            this.cancelFinalEditButton.TabIndex = 14;
            this.cancelFinalEditButton.Text = "Cancel";
            this.cancelFinalEditButton.UseVisualStyleBackColor = true;
            this.cancelFinalEditButton.Click += new System.EventHandler(this.cancelFinalEditButton_Click);
            // 
            // saveFinalDiagnosisButton
            // 
            this.saveFinalDiagnosisButton.Location = new System.Drawing.Point(234, 89);
            this.saveFinalDiagnosisButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveFinalDiagnosisButton.Name = "saveFinalDiagnosisButton";
            this.saveFinalDiagnosisButton.Size = new System.Drawing.Size(118, 22);
            this.saveFinalDiagnosisButton.TabIndex = 15;
            this.saveFinalDiagnosisButton.Text = "Save Final Diagnosis";
            this.saveFinalDiagnosisButton.UseVisualStyleBackColor = true;
            this.saveFinalDiagnosisButton.Click += new System.EventHandler(this.saveFinalDiagnosisButton_Click);
            // 
            // messageTextLabel
            // 
            this.messageTextLabel.AutoSize = true;
            this.messageTextLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageTextLabel.Location = new System.Drawing.Point(324, 25);
            this.messageTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageTextLabel.Name = "messageTextLabel";
            this.messageTextLabel.Size = new System.Drawing.Size(13, 13);
            this.messageTextLabel.TabIndex = 10;
            this.messageTextLabel.Text = "--";
            // 
            // testNameHeader
            // 
            this.testNameHeader.Text = "Test name";
            this.testNameHeader.Width = 162;
            // 
            // resultHeader
            // 
            this.resultHeader.Text = "Results";
            this.resultHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultHeader.Width = 160;
            // 
            // datePerformedHeader
            // 
            this.datePerformedHeader.Text = "Performed on";
            this.datePerformedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datePerformedHeader.Width = 90;
            // 
            // normalNotNormalHeader
            // 
            this.normalNotNormalHeader.Text = "Normal/Abnormal";
            this.normalNotNormalHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.normalNotNormalHeader.Width = 100;
            // 
            // PatientVisitListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageTextLabel);
            this.Controls.Add(this.labsOrderedLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.currentVisitIDLabel);
            this.Controls.Add(this.visitID_Label);
            this.Controls.Add(this.visitListComboBox);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientVisitListUserControl";
            this.Size = new System.Drawing.Size(615, 269);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.patientInformationPanel.ResumeLayout(false);
            this.patientInformationPanel.PerformLayout();
            this.labOrdersPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.ComboBox visitListComboBox;
        private System.Windows.Forms.Label visitID_Label;
        private System.Windows.Forms.Label currentVisitIDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labsOrderedLabel;
        private System.Windows.Forms.Panel patientInformationPanel;
        private System.Windows.Forms.Panel labOrdersPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView labResultListView;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Label dobValueLabel;
        private System.Windows.Forms.Label patientNameValueLabel;
        private System.Windows.Forms.Label phoneValueLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label bpLabel;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label enteredByLabel;
        private System.Windows.Forms.Label enterDiagnosisLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label pulseValueLabel;
        private System.Windows.Forms.Label tempValueLabel;
        private System.Windows.Forms.Label bpValueLabel;
        private System.Windows.Forms.Label weightValueLabel;
        private System.Windows.Forms.Label heightValuelabel;
        private System.Windows.Forms.Label enteredByValueLabel;
        private System.Windows.Forms.TextBox symptomsValueTextBox;
        private System.Windows.Forms.TextBox initialDiagnosisTextBox;
        private System.Windows.Forms.TextBox finalDiagnosisTextBox;
        private System.Windows.Forms.Label updateMessage;
        private System.Windows.Forms.Button orderAdditionalTestButton;
        private System.Windows.Forms.Button saveFinalDiagnosisButton;
        private System.Windows.Forms.Button cancelFinalEditButton;
        private System.Windows.Forms.Label messageTextLabel;
        private System.Windows.Forms.ColumnHeader testNameHeader;
        private System.Windows.Forms.ColumnHeader resultHeader;
        private System.Windows.Forms.ColumnHeader datePerformedHeader;
        private System.Windows.Forms.ColumnHeader normalNotNormalHeader;
    }
}
