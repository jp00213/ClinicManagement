namespace ClinicManagementApp.UserControls
{
    partial class SearchPatientUserControl
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
            this.searchPatientPanel = new System.Windows.Forms.Panel();
            this.patientIDShow = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.Label();
            this.patientListView = new System.Windows.Forms.ListView();
            this.patientIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.patientSearchButton = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobRadio = new System.Windows.Forms.RadioButton();
            this.lastDOBRadio = new System.Windows.Forms.RadioButton();
            this.firstAndLastNameRadio = new System.Windows.Forms.RadioButton();
            this.searchOptionaLabel = new System.Windows.Forms.Label();
            this.searchTitle = new System.Windows.Forms.Label();
            this.searchPatientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPatientPanel
            // 
            this.searchPatientPanel.Controls.Add(this.patientIDShow);
            this.searchPatientPanel.Controls.Add(this.messageBox);
            this.searchPatientPanel.Controls.Add(this.patientListView);
            this.searchPatientPanel.Controls.Add(this.clearButton);
            this.searchPatientPanel.Controls.Add(this.patientSearchButton);
            this.searchPatientPanel.Controls.Add(this.dobDateTimePicker);
            this.searchPatientPanel.Controls.Add(this.lastNameTextBox);
            this.searchPatientPanel.Controls.Add(this.firstNameTextBox);
            this.searchPatientPanel.Controls.Add(this.dobLabel);
            this.searchPatientPanel.Controls.Add(this.lastNameLabel);
            this.searchPatientPanel.Controls.Add(this.firstNameLabel);
            this.searchPatientPanel.Controls.Add(this.dobRadio);
            this.searchPatientPanel.Controls.Add(this.lastDOBRadio);
            this.searchPatientPanel.Controls.Add(this.firstAndLastNameRadio);
            this.searchPatientPanel.Controls.Add(this.searchOptionaLabel);
            this.searchPatientPanel.Controls.Add(this.searchTitle);
            this.searchPatientPanel.Location = new System.Drawing.Point(4, 0);
            this.searchPatientPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPatientPanel.Name = "searchPatientPanel";
            this.searchPatientPanel.Size = new System.Drawing.Size(888, 214);
            this.searchPatientPanel.TabIndex = 0;
            // 
            // patientIDShow
            // 
            this.patientIDShow.AutoSize = true;
            this.patientIDShow.Location = new System.Drawing.Point(212, 16);
            this.patientIDShow.Name = "patientIDShow";
            this.patientIDShow.Size = new System.Drawing.Size(14, 16);
            this.patientIDShow.TabIndex = 11;
            this.patientIDShow.Text = "0";
            this.patientIDShow.Visible = false;
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageBox.Location = new System.Drawing.Point(424, 0);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(0, 16);
            this.messageBox.TabIndex = 10;
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientIDHeader,
            this.lastNameHeader,
            this.firstNameHeader,
            this.dobHeader});
            this.patientListView.FullRowSelect = true;
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(21, 86);
            this.patientListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(691, 86);
            this.patientListView.TabIndex = 20;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            this.patientListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.patientListView_MouseClick);
            // 
            // patientIDHeader
            // 
            this.patientIDHeader.Text = "PatientID";
            this.patientIDHeader.Width = 190;
            // 
            // lastNameHeader
            // 
            this.lastNameHeader.Text = "Last Name";
            this.lastNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameHeader.Width = 223;
            // 
            // firstNameHeader
            // 
            this.firstNameHeader.Text = "First name";
            this.firstNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameHeader.Width = 211;
            // 
            // dobHeader
            // 
            this.dobHeader.Text = "DOB";
            this.dobHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobHeader.Width = 127;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(647, 55);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(67, 25);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientSearchButton.Location = new System.Drawing.Point(539, 55);
            this.patientSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientSearchButton.Name = "patientSearchButton";
            this.patientSearchButton.Size = new System.Drawing.Size(103, 25);
            this.patientSearchButton.TabIndex = 18;
            this.patientSearchButton.Text = "Search";
            this.patientSearchButton.UseVisualStyleBackColor = false;
            this.patientSearchButton.Click += new System.EventHandler(this.patientSearchButton_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(355, 57);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dobDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.dobDateTimePicker.TabIndex = 17;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(189, 55);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(159, 22);
            this.lastNameTextBox.TabIndex = 16;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(23, 55);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.firstNameTextBox.TabIndex = 15;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dobLabel.Location = new System.Drawing.Point(331, 33);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(190, 20);
            this.dobLabel.TabIndex = 17;
            this.dobLabel.Text = "DOB: month/day/year";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(212, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 20);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(45, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(102, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // dobRadio
            // 
            this.dobRadio.AutoSize = true;
            this.dobRadio.Location = new System.Drawing.Point(649, 10);
            this.dobRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobRadio.Name = "dobRadio";
            this.dobRadio.Size = new System.Drawing.Size(57, 20);
            this.dobRadio.TabIndex = 14;
            this.dobRadio.TabStop = true;
            this.dobRadio.Text = "DOB";
            this.dobRadio.UseVisualStyleBackColor = true;
            this.dobRadio.CheckedChanged += new System.EventHandler(this.dobRadio_CheckedChanged);
            // 
            // lastDOBRadio
            // 
            this.lastDOBRadio.AutoSize = true;
            this.lastDOBRadio.Location = new System.Drawing.Point(480, 10);
            this.lastDOBRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastDOBRadio.Name = "lastDOBRadio";
            this.lastDOBRadio.Size = new System.Drawing.Size(151, 20);
            this.lastDOBRadio.TabIndex = 13;
            this.lastDOBRadio.TabStop = true;
            this.lastDOBRadio.Text = "Last Name and DOB";
            this.lastDOBRadio.UseVisualStyleBackColor = true;
            this.lastDOBRadio.CheckedChanged += new System.EventHandler(this.lastDOBRadio_CheckedChanged);
            // 
            // firstAndLastNameRadio
            // 
            this.firstAndLastNameRadio.AutoSize = true;
            this.firstAndLastNameRadio.Location = new System.Drawing.Point(316, 10);
            this.firstAndLastNameRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstAndLastNameRadio.Name = "firstAndLastNameRadio";
            this.firstAndLastNameRadio.Size = new System.Drawing.Size(147, 20);
            this.firstAndLastNameRadio.TabIndex = 12;
            this.firstAndLastNameRadio.TabStop = true;
            this.firstAndLastNameRadio.Text = "First and Last Name";
            this.firstAndLastNameRadio.UseVisualStyleBackColor = true;
            this.firstAndLastNameRadio.CheckedChanged += new System.EventHandler(this.firstAndLastNameRadio_CheckedChanged);
            // 
            // searchOptionaLabel
            // 
            this.searchOptionaLabel.AutoSize = true;
            this.searchOptionaLabel.Location = new System.Drawing.Point(233, 12);
            this.searchOptionaLabel.Name = "searchOptionaLabel";
            this.searchOptionaLabel.Size = new System.Drawing.Size(71, 16);
            this.searchOptionaLabel.TabIndex = 15;
            this.searchOptionaLabel.Text = "Search by:";
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(17, 9);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(214, 20);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "View Patient Information";
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPatientPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(924, 320);
            this.searchPatientPanel.ResumeLayout(false);
            this.searchPatientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPatientPanel;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Label searchOptionaLabel;
        private System.Windows.Forms.RadioButton firstAndLastNameRadio;
        private System.Windows.Forms.RadioButton dobRadio;
        private System.Windows.Forms.RadioButton lastDOBRadio;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Button patientSearchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ColumnHeader patientIDHeader;
        private System.Windows.Forms.ColumnHeader lastNameHeader;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader dobHeader;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.Label patientIDShow;
    }
}
