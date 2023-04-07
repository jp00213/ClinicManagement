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
            this.documentVisitLabel = new System.Windows.Forms.Label();
            this.dateOfApptLabel = new System.Windows.Forms.Label();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.dividerLabel2 = new System.Windows.Forms.Label();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.activeNameLabel = new System.Windows.Forms.Label();
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
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // documentVisitLabel
            // 
            this.documentVisitLabel.AutoSize = true;
            this.documentVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentVisitLabel.Location = new System.Drawing.Point(308, 12);
            this.documentVisitLabel.Name = "documentVisitLabel";
            this.documentVisitLabel.Size = new System.Drawing.Size(150, 24);
            this.documentVisitLabel.TabIndex = 0;
            this.documentVisitLabel.Text = "Document Visit";
            // 
            // dateOfApptLabel
            // 
            this.dateOfApptLabel.AutoSize = true;
            this.dateOfApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfApptLabel.Location = new System.Drawing.Point(161, 44);
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
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(164, 63);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(136, 21);
            this.appointmentDateTimePicker.TabIndex = 2;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLabel.Location = new System.Drawing.Point(349, 42);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(52, 15);
            this.patientLabel.TabIndex = 3;
            this.patientLabel.Text = "Patient";
            // 
            // patientComboBox
            // 
            this.patientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(352, 61);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(121, 23);
            this.patientComboBox.TabIndex = 4;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(506, 60);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(99, 24);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
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
            // activeNameLabel
            // 
            this.activeNameLabel.AutoSize = true;
            this.activeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNameLabel.Location = new System.Drawing.Point(83, 130);
            this.activeNameLabel.Name = "activeNameLabel";
            this.activeNameLabel.Size = new System.Drawing.Size(95, 13);
            this.activeNameLabel.TabIndex = 10;
            this.activeNameLabel.Text = "James Buchannan";
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
            this.activeDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDOBLabel.Location = new System.Drawing.Point(251, 130);
            this.activeDOBLabel.Name = "activeDOBLabel";
            this.activeDOBLabel.Size = new System.Drawing.Size(65, 13);
            this.activeDOBLabel.TabIndex = 12;
            this.activeDOBLabel.Text = "07/18/1987";
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
            this.activePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePhoneLabel.Location = new System.Drawing.Point(391, 130);
            this.activePhoneLabel.Name = "activePhoneLabel";
            this.activePhoneLabel.Size = new System.Drawing.Size(67, 13);
            this.activePhoneLabel.TabIndex = 14;
            this.activePhoneLabel.Text = "7064651395";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(488, 130);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address:";
            // 
            // activeAddressLabel
            // 
            this.activeAddressLabel.AutoSize = true;
            this.activeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeAddressLabel.Location = new System.Drawing.Point(543, 129);
            this.activeAddressLabel.Name = "activeAddressLabel";
            this.activeAddressLabel.Size = new System.Drawing.Size(25, 13);
            this.activeAddressLabel.TabIndex = 16;
            this.activeAddressLabel.Text = "123";
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
            this.activeDoctorNameLabel.Location = new System.Drawing.Point(277, 166);
            this.activeDoctorNameLabel.Name = "activeDoctorNameLabel";
            this.activeDoctorNameLabel.Size = new System.Drawing.Size(100, 15);
            this.activeDoctorNameLabel.TabIndex = 19;
            this.activeDoctorNameLabel.Text = "Dr.";
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
            this.activeDoctorIDLabel.Location = new System.Drawing.Point(277, 181);
            this.activeDoctorIDLabel.Name = "activeDoctorIDLabel";
            this.activeDoctorIDLabel.Size = new System.Drawing.Size(58, 13);
            this.activeDoctorIDLabel.TabIndex = 22;
            this.activeDoctorIDLabel.Text = "111";
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
            this.labsListBox.DataSource = this.appointmentBindingSource;
            this.labsListBox.FormattingEnabled = true;
            this.labsListBox.Location = new System.Drawing.Point(506, 241);
            this.labsListBox.Name = "labsListBox";
            this.labsListBox.Size = new System.Drawing.Size(225, 277);
            this.labsListBox.TabIndex = 24;
            // 
            // activeSpecialtyLabel
            // 
            this.activeSpecialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeSpecialtyLabel.Location = new System.Drawing.Point(277, 196);
            this.activeSpecialtyLabel.Name = "activeSpecialtyLabel";
            this.activeSpecialtyLabel.Size = new System.Drawing.Size(100, 23);
            this.activeSpecialtyLabel.TabIndex = 25;
            this.activeSpecialtyLabel.Text = "Endo";
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
            this.activeNurseNameLabel.Location = new System.Drawing.Point(532, 168);
            this.activeNurseNameLabel.Name = "activeNurseNameLabel";
            this.activeNurseNameLabel.Size = new System.Drawing.Size(47, 13);
            this.activeNurseNameLabel.TabIndex = 28;
            this.activeNurseNameLabel.Text = "Nurseee";
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
            this.activeNurseIDLabel.Location = new System.Drawing.Point(532, 189);
            this.activeNurseIDLabel.Name = "activeNurseIDLabel";
            this.activeNurseIDLabel.Size = new System.Drawing.Size(19, 13);
            this.activeNurseIDLabel.TabIndex = 30;
            this.activeNurseIDLabel.Text = "11";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(297, 535);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(215, 27);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save Appointment";
            this.saveButton.UseVisualStyleBackColor = true;
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
            this.weightTextBox.Location = new System.Drawing.Point(352, 252);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(139, 20);
            this.weightTextBox.TabIndex = 35;
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
            this.diastolicTextBox.Location = new System.Drawing.Point(102, 293);
            this.diastolicTextBox.Name = "diastolicTextBox";
            this.diastolicTextBox.Size = new System.Drawing.Size(139, 20);
            this.diastolicTextBox.TabIndex = 37;
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
            this.systolicTextBox.Location = new System.Drawing.Point(352, 292);
            this.systolicTextBox.Name = "systolicTextBox";
            this.systolicTextBox.Size = new System.Drawing.Size(139, 20);
            this.systolicTextBox.TabIndex = 39;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(102, 335);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(139, 20);
            this.temperatureTextBox.TabIndex = 40;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(352, 334);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(139, 20);
            this.pulseTextBox.TabIndex = 41;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(102, 376);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(139, 143);
            this.symptomsTextBox.TabIndex = 42;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 375);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 143);
            this.textBox1.TabIndex = 49;
            // 
            // DocumentVisitUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.activeNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientInformationLabel);
            this.Controls.Add(this.dividerLabel2);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.dateOfApptLabel);
            this.Controls.Add(this.documentVisitLabel);
            this.Name = "DocumentVisitUserControl";
            this.Size = new System.Drawing.Size(804, 576);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label documentVisitLabel;
        private System.Windows.Forms.Label dateOfApptLabel;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label dividerLabel2;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label activeNameLabel;
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
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.NumericUpDown feetNumericUpDown;
        private System.Windows.Forms.NumericUpDown inchesNumericUpDown;
        private System.Windows.Forms.Label initialDiagnosisLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
