namespace ClinicManagementApp.UserControls
{
    partial class DocumentVisitUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateOfApptLabel = new System.Windows.Forms.Label();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectButton = new System.Windows.Forms.Button();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.dividerLabel2 = new System.Windows.Forms.Label();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.activeFirstNameLabel = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobLabel = new System.Windows.Forms.Label();
            this.activeDOBLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.activePhoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.activeAddressLabel = new System.Windows.Forms.Label();
            this.doctorInformationLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.activeDoctorNameLabel = new System.Windows.Forms.Label();
            this.dividerLabel3 = new System.Windows.Forms.Label();
            this.doctorIDNumberLabel = new System.Windows.Forms.Label();
            this.activeDoctorIDLabel = new System.Windows.Forms.Label();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.labsListBox = new System.Windows.Forms.ListBox();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeSpecialtyLabel = new System.Windows.Forms.Label();
            this.nurseInfoLabel = new System.Windows.Forms.Label();
            this.nurseNameLabel = new System.Windows.Forms.Label();
            this.activeNurseNameLabel = new System.Windows.Forms.Label();
            this.nurseIDLabel = new System.Windows.Forms.Label();
            this.activeNurseIDLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.diastolicLabel = new System.Windows.Forms.Label();
            this.diastolicTextBox = new System.Windows.Forms.TextBox();
            this.systolicLabel = new System.Windows.Forms.Label();
            this.systolicTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.feetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inchesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialDiagnosisLabel = new System.Windows.Forms.Label();
            this.initialDiagnosisTextbox = new System.Windows.Forms.TextBox();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeLastNameLabel = new System.Windows.Forms.Label();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.finalDiagnosisLabel = new System.Windows.Forms.Label();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.heightErrorLabel = new System.Windows.Forms.Label();
            this.diastolicBloodPressureErrorLabel = new System.Windows.Forms.Label();
            this.bodyTemperatureErrorLabel = new System.Windows.Forms.Label();
            this.symptomsErrorLabel = new System.Windows.Forms.Label();
            this.weightErrorLabel = new System.Windows.Forms.Label();
            this.systolicErrorLabel = new System.Windows.Forms.Label();
            this.pulseErrorLabel = new System.Windows.Forms.Label();
            this.initialDiagnosisErrorLabel = new System.Windows.Forms.Label();
            this.generalErrorLabel = new System.Windows.Forms.Label();
            this.labTestsLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfApptLabel
            // 
            this.dateOfApptLabel.AutoSize = true;
            this.dateOfApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfApptLabel.Location = new System.Drawing.Point(87, 16);
            this.dateOfApptLabel.Name = "dateOfApptLabel";
            this.dateOfApptLabel.Size = new System.Drawing.Size(139, 15);
            this.dateOfApptLabel.TabIndex = 1;
            this.dateOfApptLabel.Text = "Date Of Appointment";
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(90, 35);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(136, 21);
            this.appointmentDateTimePicker.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(102, 62);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(102, 33);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel.Location = new System.Drawing.Point(45, 98);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(686, 3);
            this.dividerLabel.TabIndex = 6;
            // 
            // dividerLabel2
            // 
            this.dividerLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel2.Location = new System.Drawing.Point(45, 219);
            this.dividerLabel2.Name = "dividerLabel2";
            this.dividerLabel2.Size = new System.Drawing.Size(686, 3);
            this.dividerLabel2.TabIndex = 7;
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationLabel.Location = new System.Drawing.Point(321, 105);
            this.patientInformationLabel.Name = "patientInformationLabel";
            this.patientInformationLabel.Size = new System.Drawing.Size(135, 16);
            this.patientInformationLabel.TabIndex = 8;
            this.patientInformationLabel.Text = "Patient Information";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(42, 130);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(38, 13);
            this.patientNameLabel.TabIndex = 9;
            this.patientNameLabel.Text = "Name:";
            // 
            // activeFirstNameLabel
            // 
            this.activeFirstNameLabel.AutoSize = true;
            this.activeFirstNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.activeFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeFirstNameLabel.Location = new System.Drawing.Point(83, 130);
            this.activeFirstNameLabel.Name = "activeFirstNameLabel";
            this.activeFirstNameLabel.Size = new System.Drawing.Size(0, 13);
            this.activeFirstNameLabel.TabIndex = 10;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicManagementApp.Model.Patient);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(209, 130);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(36, 13);
            this.dobLabel.TabIndex = 11;
            this.dobLabel.Text = "DOB: ";
            // 
            // activeDOBLabel
            // 
            this.activeDOBLabel.AutoSize = true;
            this.activeDOBLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "DateOfBirth", true));
            this.activeDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDOBLabel.Location = new System.Drawing.Point(251, 130);
            this.activeDOBLabel.Name = "activeDOBLabel";
            this.activeDOBLabel.Size = new System.Drawing.Size(0, 13);
            this.activeDOBLabel.TabIndex = 12;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(343, 130);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone:";
            // 
            // activePhoneLabel
            // 
            this.activePhoneLabel.AutoSize = true;
            this.activePhoneLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.activePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePhoneLabel.Location = new System.Drawing.Point(391, 130);
            this.activePhoneLabel.Name = "activePhoneLabel";
            this.activePhoneLabel.Size = new System.Drawing.Size(0, 13);
            this.activePhoneLabel.TabIndex = 14;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(482, 130);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address:";
            // 
            // activeAddressLabel
            // 
            this.activeAddressLabel.AutoSize = true;
            this.activeAddressLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "AddressStreet", true));
            this.activeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeAddressLabel.Location = new System.Drawing.Point(536, 117);
            this.activeAddressLabel.Name = "activeAddressLabel";
            this.activeAddressLabel.Size = new System.Drawing.Size(0, 13);
            this.activeAddressLabel.TabIndex = 16;
            // 
            // doctorInformationLabel
            // 
            this.doctorInformationLabel.AutoSize = true;
            this.doctorInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorInformationLabel.Location = new System.Drawing.Point(193, 150);
            this.doctorInformationLabel.Name = "doctorInformationLabel";
            this.doctorInformationLabel.Size = new System.Drawing.Size(133, 16);
            this.doctorInformationLabel.TabIndex = 17;
            this.doctorInformationLabel.Text = "Doctor Information";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(200, 166);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(45, 15);
            this.doctorNameLabel.TabIndex = 18;
            this.doctorNameLabel.Text = "Name:";
            // 
            // activeDoctorNameLabel
            // 
            this.activeDoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorNameLabel.Location = new System.Drawing.Point(242, 166);
            this.activeDoctorNameLabel.Name = "activeDoctorNameLabel";
            this.activeDoctorNameLabel.Size = new System.Drawing.Size(100, 15);
            this.activeDoctorNameLabel.TabIndex = 19;
            // 
            // dividerLabel3
            // 
            this.dividerLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel3.Location = new System.Drawing.Point(45, 149);
            this.dividerLabel3.Name = "dividerLabel3";
            this.dividerLabel3.Size = new System.Drawing.Size(686, 2);
            this.dividerLabel3.TabIndex = 20;
            // 
            // doctorIDNumberLabel
            // 
            this.doctorIDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIDNumberLabel.Location = new System.Drawing.Point(179, 181);
            this.doctorIDNumberLabel.Name = "doctorIDNumberLabel";
            this.doctorIDNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.doctorIDNumberLabel.TabIndex = 21;
            this.doctorIDNumberLabel.Text = "ID Number:";
            // 
            // activeDoctorIDLabel
            // 
            this.activeDoctorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorIDLabel.Location = new System.Drawing.Point(242, 181);
            this.activeDoctorIDLabel.Name = "activeDoctorIDLabel";
            this.activeDoctorIDLabel.Size = new System.Drawing.Size(58, 13);
            this.activeDoctorIDLabel.TabIndex = 22;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtyLabel.Location = new System.Drawing.Point(185, 196);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(60, 23);
            this.specialtyLabel.TabIndex = 23;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // labsListBox
            // 
            this.labsListBox.DataSource = this.labTestBindingSource;
            this.labsListBox.DisplayMember = "TestName";
            this.labsListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsListBox.FormattingEnabled = true;
            this.labsListBox.ItemHeight = 14;
            this.labsListBox.Location = new System.Drawing.Point(506, 249);
            this.labsListBox.Name = "labsListBox";
            this.labsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.labsListBox.Size = new System.Drawing.Size(225, 270);
            this.labsListBox.TabIndex = 24;
            this.labsListBox.ValueMember = "TestCode";
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(ClinicManagementApp.Model.LabTest);
            // 
            // activeSpecialtyLabel
            // 
            this.activeSpecialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeSpecialtyLabel.Location = new System.Drawing.Point(242, 196);
            this.activeSpecialtyLabel.Name = "activeSpecialtyLabel";
            this.activeSpecialtyLabel.Size = new System.Drawing.Size(214, 23);
            this.activeSpecialtyLabel.TabIndex = 25;
            // 
            // nurseInfoLabel
            // 
            this.nurseInfoLabel.AutoSize = true;
            this.nurseInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseInfoLabel.Location = new System.Drawing.Point(450, 152);
            this.nurseInfoLabel.Name = "nurseInfoLabel";
            this.nurseInfoLabel.Size = new System.Drawing.Size(128, 16);
            this.nurseInfoLabel.TabIndex = 26;
            this.nurseInfoLabel.Text = "Nurse Information";
            // 
            // nurseNameLabel
            // 
            this.nurseNameLabel.AutoSize = true;
            this.nurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameLabel.Location = new System.Drawing.Point(465, 168);
            this.nurseNameLabel.Name = "nurseNameLabel";
            this.nurseNameLabel.Size = new System.Drawing.Size(41, 13);
            this.nurseNameLabel.TabIndex = 27;
            this.nurseNameLabel.Text = "Name: ";
            // 
            // activeNurseNameLabel
            // 
            this.activeNurseNameLabel.AutoSize = true;
            this.activeNurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNurseNameLabel.Location = new System.Drawing.Point(512, 168);
            this.activeNurseNameLabel.Name = "activeNurseNameLabel";
            this.activeNurseNameLabel.Size = new System.Drawing.Size(0, 13);
            this.activeNurseNameLabel.TabIndex = 28;
            // 
            // nurseIDLabel
            // 
            this.nurseIDLabel.AutoSize = true;
            this.nurseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDLabel.Location = new System.Drawing.Point(445, 189);
            this.nurseIDLabel.Name = "nurseIDLabel";
            this.nurseIDLabel.Size = new System.Drawing.Size(61, 13);
            this.nurseIDLabel.TabIndex = 29;
            this.nurseIDLabel.Text = "ID Number:";
            // 
            // activeNurseIDLabel
            // 
            this.activeNurseIDLabel.AutoSize = true;
            this.activeNurseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNurseIDLabel.Location = new System.Drawing.Point(517, 189);
            this.activeNurseIDLabel.Name = "activeNurseIDLabel";
            this.activeNurseIDLabel.Size = new System.Drawing.Size(0, 13);
            this.activeNurseIDLabel.TabIndex = 30;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(427, 535);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(225, 36);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save Appointment";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(47, 254);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(46, 15);
            this.heightLabel.TabIndex = 32;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(295, 252);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(51, 15);
            this.weightLabel.TabIndex = 34;
            this.weightLabel.Text = "Weight: ";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(352, 252);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(139, 20);
            this.weightTextBox.TabIndex = 35;
            this.weightTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInputIsDigits);
            // 
            // diastolicLabel
            // 
            this.diastolicLabel.AutoSize = true;
            this.diastolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicLabel.Location = new System.Drawing.Point(17, 293);
            this.diastolicLabel.Name = "diastolicLabel";
            this.diastolicLabel.Size = new System.Drawing.Size(76, 15);
            this.diastolicLabel.TabIndex = 36;
            this.diastolicLabel.Text = "Diastolic BP:";
            // 
            // diastolicTextBox
            // 
            this.diastolicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicTextBox.Location = new System.Drawing.Point(102, 293);
            this.diastolicTextBox.Name = "diastolicTextBox";
            this.diastolicTextBox.Size = new System.Drawing.Size(139, 20);
            this.diastolicTextBox.TabIndex = 37;
            this.diastolicTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.diastolicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInputIsDigits);
            // 
            // systolicLabel
            // 
            this.systolicLabel.AutoSize = true;
            this.systolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicLabel.Location = new System.Drawing.Point(276, 293);
            this.systolicLabel.Name = "systolicLabel";
            this.systolicLabel.Size = new System.Drawing.Size(70, 15);
            this.systolicLabel.TabIndex = 38;
            this.systolicLabel.Text = "Systolic BP:";
            // 
            // systolicTextBox
            // 
            this.systolicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicTextBox.Location = new System.Drawing.Point(352, 292);
            this.systolicTextBox.Name = "systolicTextBox";
            this.systolicTextBox.Size = new System.Drawing.Size(139, 20);
            this.systolicTextBox.TabIndex = 39;
            this.systolicTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.systolicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInputIsDigits);
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureTextBox.Location = new System.Drawing.Point(102, 335);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(139, 20);
            this.temperatureTextBox.TabIndex = 40;
            this.temperatureTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.temperatureTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInputIsDigits);
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseTextBox.Location = new System.Drawing.Point(352, 334);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(139, 20);
            this.pulseTextBox.TabIndex = 41;
            this.pulseTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.pulseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInputIsDigits);
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsTextBox.Location = new System.Drawing.Point(102, 376);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(139, 143);
            this.symptomsTextBox.TabIndex = 42;
            this.symptomsTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(25, 377);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(68, 15);
            this.symptomsLabel.TabIndex = 43;
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(12, 338);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(81, 15);
            this.tempLabel.TabIndex = 44;
            this.tempLabel.Text = "Temperature:";
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(305, 337);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(41, 15);
            this.pulseLabel.TabIndex = 45;
            this.pulseLabel.Text = "Pulse:";
            // 
            // feetNumericUpDown
            // 
            this.feetNumericUpDown.Location = new System.Drawing.Point(100, 253);
            this.feetNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.feetNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.feetNumericUpDown.Name = "feetNumericUpDown";
            this.feetNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.feetNumericUpDown.TabIndex = 46;
            this.feetNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.feetNumericUpDown.Click += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // inchesNumericUpDown
            // 
            this.inchesNumericUpDown.Location = new System.Drawing.Point(178, 253);
            this.inchesNumericUpDown.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.inchesNumericUpDown.Name = "inchesNumericUpDown";
            this.inchesNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.inchesNumericUpDown.TabIndex = 47;
            this.inchesNumericUpDown.Click += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // initialDiagnosisLabel
            // 
            this.initialDiagnosisLabel.AutoSize = true;
            this.initialDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDiagnosisLabel.Location = new System.Drawing.Point(251, 376);
            this.initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            this.initialDiagnosisLabel.Size = new System.Drawing.Size(97, 15);
            this.initialDiagnosisLabel.TabIndex = 48;
            this.initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // initialDiagnosisTextbox
            // 
            this.initialDiagnosisTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDiagnosisTextbox.Location = new System.Drawing.Point(352, 375);
            this.initialDiagnosisTextbox.Multiline = true;
            this.initialDiagnosisTextbox.Name = "initialDiagnosisTextbox";
            this.initialDiagnosisTextbox.Size = new System.Drawing.Size(139, 62);
            this.initialDiagnosisTextbox.TabIndex = 49;
            this.initialDiagnosisTextbox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientDataGridView.Location = new System.Drawing.Point(263, 15);
            this.patientDataGridView.MultiSelect = false;
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.patientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGridView.Size = new System.Drawing.Size(468, 80);
            this.patientDataGridView.TabIndex = 50;
            this.patientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellClick);
            this.patientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeLastNameLabel
            // 
            this.activeLastNameLabel.AutoSize = true;
            this.activeLastNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.activeLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLastNameLabel.Location = new System.Drawing.Point(133, 130);
            this.activeLastNameLabel.Name = "activeLastNameLabel";
            this.activeLastNameLabel.Size = new System.Drawing.Size(0, 13);
            this.activeLastNameLabel.TabIndex = 51;
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(120, 237);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(24, 12);
            this.feetLabel.TabIndex = 52;
            this.feetLabel.Text = "Feet";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(193, 237);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(33, 12);
            this.inchesLabel.TabIndex = 53;
            this.inchesLabel.Text = "Inches";
            // 
            // finalDiagnosisLabel
            // 
            this.finalDiagnosisLabel.AutoSize = true;
            this.finalDiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDiagnosisLabel.Location = new System.Drawing.Point(253, 458);
            this.finalDiagnosisLabel.Name = "finalDiagnosisLabel";
            this.finalDiagnosisLabel.Size = new System.Drawing.Size(95, 15);
            this.finalDiagnosisLabel.TabIndex = 54;
            this.finalDiagnosisLabel.Text = "Final Diagnosis:";
            this.finalDiagnosisLabel.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // finalDiagnosisTextBox
            // 
            this.finalDiagnosisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(352, 457);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(139, 62);
            this.finalDiagnosisTextBox.TabIndex = 55;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(123, 535);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(208, 36);
            this.clearButton.TabIndex = 57;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // heightErrorLabel
            // 
            this.heightErrorLabel.AutoSize = true;
            this.heightErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightErrorLabel.Location = new System.Drawing.Point(99, 277);
            this.heightErrorLabel.Name = "heightErrorLabel";
            this.heightErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.heightErrorLabel.TabIndex = 58;
            // 
            // diastolicBloodPressureErrorLabel
            // 
            this.diastolicBloodPressureErrorLabel.AutoSize = true;
            this.diastolicBloodPressureErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicBloodPressureErrorLabel.Location = new System.Drawing.Point(99, 319);
            this.diastolicBloodPressureErrorLabel.Name = "diastolicBloodPressureErrorLabel";
            this.diastolicBloodPressureErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.diastolicBloodPressureErrorLabel.TabIndex = 59;
            // 
            // bodyTemperatureErrorLabel
            // 
            this.bodyTemperatureErrorLabel.AutoSize = true;
            this.bodyTemperatureErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTemperatureErrorLabel.Location = new System.Drawing.Point(99, 358);
            this.bodyTemperatureErrorLabel.Name = "bodyTemperatureErrorLabel";
            this.bodyTemperatureErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.bodyTemperatureErrorLabel.TabIndex = 60;
            // 
            // symptomsErrorLabel
            // 
            this.symptomsErrorLabel.AutoSize = true;
            this.symptomsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsErrorLabel.Location = new System.Drawing.Point(97, 522);
            this.symptomsErrorLabel.Name = "symptomsErrorLabel";
            this.symptomsErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.symptomsErrorLabel.TabIndex = 61;
            // 
            // weightErrorLabel
            // 
            this.weightErrorLabel.AutoSize = true;
            this.weightErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightErrorLabel.Location = new System.Drawing.Point(352, 273);
            this.weightErrorLabel.Name = "weightErrorLabel";
            this.weightErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.weightErrorLabel.TabIndex = 62;
            // 
            // systolicErrorLabel
            // 
            this.systolicErrorLabel.AutoSize = true;
            this.systolicErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicErrorLabel.Location = new System.Drawing.Point(352, 317);
            this.systolicErrorLabel.Name = "systolicErrorLabel";
            this.systolicErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.systolicErrorLabel.TabIndex = 63;
            // 
            // pulseErrorLabel
            // 
            this.pulseErrorLabel.AutoSize = true;
            this.pulseErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseErrorLabel.Location = new System.Drawing.Point(352, 358);
            this.pulseErrorLabel.Name = "pulseErrorLabel";
            this.pulseErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.pulseErrorLabel.TabIndex = 64;
            // 
            // initialDiagnosisErrorLabel
            // 
            this.initialDiagnosisErrorLabel.AutoSize = true;
            this.initialDiagnosisErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDiagnosisErrorLabel.Location = new System.Drawing.Point(351, 441);
            this.initialDiagnosisErrorLabel.Name = "initialDiagnosisErrorLabel";
            this.initialDiagnosisErrorLabel.Size = new System.Drawing.Size(0, 12);
            this.initialDiagnosisErrorLabel.TabIndex = 65;
            // 
            // generalErrorLabel
            // 
            this.generalErrorLabel.AutoSize = true;
            this.generalErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalErrorLabel.Location = new System.Drawing.Point(163, 222);
            this.generalErrorLabel.Name = "generalErrorLabel";
            this.generalErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.generalErrorLabel.TabIndex = 66;
            // 
            // labTestsLabel
            // 
            this.labTestsLabel.AutoSize = true;
            this.labTestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestsLabel.Location = new System.Drawing.Point(562, 231);
            this.labTestsLabel.Name = "labTestsLabel";
            this.labTestsLabel.Size = new System.Drawing.Size(112, 15);
            this.labTestsLabel.TabIndex = 67;
            this.labTestsLabel.Text = "Available Lab Tests";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(536, 130);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 13);
            this.cityLabel.TabIndex = 68;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "State", true));
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(597, 130);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 13);
            this.stateLabel.TabIndex = 69;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Zip", true));
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(626, 130);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(0, 13);
            this.zipLabel.TabIndex = 70;
            // 
            // DocumentVisitUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.labTestsLabel);
            this.Controls.Add(this.generalErrorLabel);
            this.Controls.Add(this.initialDiagnosisErrorLabel);
            this.Controls.Add(this.pulseErrorLabel);
            this.Controls.Add(this.systolicErrorLabel);
            this.Controls.Add(this.weightErrorLabel);
            this.Controls.Add(this.symptomsErrorLabel);
            this.Controls.Add(this.bodyTemperatureErrorLabel);
            this.Controls.Add(this.diastolicBloodPressureErrorLabel);
            this.Controls.Add(this.heightErrorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.finalDiagnosisTextBox);
            this.Controls.Add(this.finalDiagnosisLabel);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.activeLastNameLabel);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.initialDiagnosisTextbox);
            this.Controls.Add(this.initialDiagnosisLabel);
            this.Controls.Add(this.inchesNumericUpDown);
            this.Controls.Add(this.feetNumericUpDown);
            this.Controls.Add(this.pulseLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(this.pulseTextBox);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.systolicTextBox);
            this.Controls.Add(this.systolicLabel);
            this.Controls.Add(this.diastolicTextBox);
            this.Controls.Add(this.diastolicLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.activeNurseIDLabel);
            this.Controls.Add(this.nurseIDLabel);
            this.Controls.Add(this.activeNurseNameLabel);
            this.Controls.Add(this.nurseNameLabel);
            this.Controls.Add(this.nurseInfoLabel);
            this.Controls.Add(this.activeSpecialtyLabel);
            this.Controls.Add(this.labsListBox);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.activeDoctorIDLabel);
            this.Controls.Add(this.doctorIDNumberLabel);
            this.Controls.Add(this.dividerLabel3);
            this.Controls.Add(this.activeDoctorNameLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.doctorInformationLabel);
            this.Controls.Add(this.activeAddressLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.activePhoneLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.activeDOBLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.activeFirstNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientInformationLabel);
            this.Controls.Add(this.dividerLabel2);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.dateOfApptLabel);
            this.Name = "DocumentVisitUserControl";
            this.Size = new System.Drawing.Size(804, 576);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateOfApptLabel;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label dividerLabel2;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label activeFirstNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label activeDOBLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label activePhoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label activeAddressLabel;
        private System.Windows.Forms.Label doctorInformationLabel;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label activeDoctorNameLabel;
        private System.Windows.Forms.Label dividerLabel3;
        private System.Windows.Forms.Label doctorIDNumberLabel;
        private System.Windows.Forms.Label activeDoctorIDLabel;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.ListBox labsListBox;
        private System.Windows.Forms.Label activeSpecialtyLabel;
        private System.Windows.Forms.Label nurseInfoLabel;
        private System.Windows.Forms.Label nurseNameLabel;
        private System.Windows.Forms.Label activeNurseNameLabel;
        private System.Windows.Forms.Label nurseIDLabel;
        private System.Windows.Forms.Label activeNurseIDLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label diastolicLabel;
        private System.Windows.Forms.TextBox diastolicTextBox;
        private System.Windows.Forms.Label systolicLabel;
        private System.Windows.Forms.TextBox systolicTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.NumericUpDown feetNumericUpDown;
        private System.Windows.Forms.NumericUpDown inchesNumericUpDown;
        private System.Windows.Forms.Label initialDiagnosisLabel;
        private System.Windows.Forms.TextBox initialDiagnosisTextbox;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label activeLastNameLabel;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Label finalDiagnosisLabel;
        private System.Windows.Forms.TextBox finalDiagnosisTextBox;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label heightErrorLabel;
        private System.Windows.Forms.Label diastolicBloodPressureErrorLabel;
        private System.Windows.Forms.Label bodyTemperatureErrorLabel;
        private System.Windows.Forms.Label symptomsErrorLabel;
        private System.Windows.Forms.Label weightErrorLabel;
        private System.Windows.Forms.Label systolicErrorLabel;
        private System.Windows.Forms.Label pulseErrorLabel;
        private System.Windows.Forms.Label initialDiagnosisErrorLabel;
        private System.Windows.Forms.Label generalErrorLabel;
        private System.Windows.Forms.Label labTestsLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
    }
}
