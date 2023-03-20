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
            this.searchPatientPanel.Location = new System.Drawing.Point(3, 0);
            this.searchPatientPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientPanel.Name = "searchPatientPanel";
            this.searchPatientPanel.Size = new System.Drawing.Size(666, 174);
            this.searchPatientPanel.TabIndex = 0;
            // 
            // patientIDShow
            // 
            this.patientIDShow.AutoSize = true;
            this.patientIDShow.Location = new System.Drawing.Point(182, 15);
            this.patientIDShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIDShow.Name = "patientIDShow";
            this.patientIDShow.Size = new System.Drawing.Size(13, 13);
            this.patientIDShow.TabIndex = 11;
            this.patientIDShow.Text = "--";
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.messageBox.Location = new System.Drawing.Point(414, 33);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(0, 13);
            this.messageBox.TabIndex = 10;
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientIDHeader,
            this.lastNameHeader,
            this.firstNameHeader,
            this.dobHeader});
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(0, 70);
            this.patientListView.Margin = new System.Windows.Forms.Padding(2);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(554, 88);
            this.patientListView.TabIndex = 9;
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
            this.clearButton.Location = new System.Drawing.Point(452, 49);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 18);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientSearchButton.Location = new System.Drawing.Point(371, 49);
            this.patientSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.patientSearchButton.Name = "patientSearchButton";
            this.patientSearchButton.Size = new System.Drawing.Size(77, 18);
            this.patientSearchButton.TabIndex = 8;
            this.patientSearchButton.Text = "Search";
            this.patientSearchButton.UseVisualStyleBackColor = false;
            this.patientSearchButton.Click += new System.EventHandler(this.patientSearchButton_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDateTimePicker.Location = new System.Drawing.Point(232, 51);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dobDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dobDateTimePicker.TabIndex = 7;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(119, 51);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(2, 51);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.dobLabel.Location = new System.Drawing.Point(231, 33);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(136, 13);
            this.dobLabel.TabIndex = 17;
            this.dobLabel.Text = "DOB: year/month/date";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(142, 36);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(67, 13);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(26, 36);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // dobRadio
            // 
            this.dobRadio.AutoSize = true;
            this.dobRadio.Location = new System.Drawing.Point(507, 12);
            this.dobRadio.Margin = new System.Windows.Forms.Padding(2);
            this.dobRadio.Name = "dobRadio";
            this.dobRadio.Size = new System.Drawing.Size(48, 17);
            this.dobRadio.TabIndex = 14;
            this.dobRadio.TabStop = true;
            this.dobRadio.Text = "DOB";
            this.dobRadio.UseVisualStyleBackColor = true;
            this.dobRadio.CheckedChanged += new System.EventHandler(this.dobRadio_CheckedChanged);
            // 
            // lastDOBRadio
            // 
            this.lastDOBRadio.AutoSize = true;
            this.lastDOBRadio.Location = new System.Drawing.Point(381, 12);
            this.lastDOBRadio.Margin = new System.Windows.Forms.Padding(2);
            this.lastDOBRadio.Name = "lastDOBRadio";
            this.lastDOBRadio.Size = new System.Drawing.Size(123, 17);
            this.lastDOBRadio.TabIndex = 13;
            this.lastDOBRadio.TabStop = true;
            this.lastDOBRadio.Text = "Last Name and DOB";
            this.lastDOBRadio.UseVisualStyleBackColor = true;
            this.lastDOBRadio.CheckedChanged += new System.EventHandler(this.lastDOBRadio_CheckedChanged);
            // 
            // firstAndLastNameRadio
            // 
            this.firstAndLastNameRadio.AutoSize = true;
            this.firstAndLastNameRadio.Location = new System.Drawing.Point(259, 12);
            this.firstAndLastNameRadio.Margin = new System.Windows.Forms.Padding(2);
            this.firstAndLastNameRadio.Name = "firstAndLastNameRadio";
            this.firstAndLastNameRadio.Size = new System.Drawing.Size(119, 17);
            this.firstAndLastNameRadio.TabIndex = 12;
            this.firstAndLastNameRadio.TabStop = true;
            this.firstAndLastNameRadio.Text = "First and Last Name";
            this.firstAndLastNameRadio.UseVisualStyleBackColor = true;
            this.firstAndLastNameRadio.CheckedChanged += new System.EventHandler(this.firstAndLastNameRadio_CheckedChanged);
            // 
            // searchOptionaLabel
            // 
            this.searchOptionaLabel.AutoSize = true;
            this.searchOptionaLabel.Location = new System.Drawing.Point(199, 14);
            this.searchOptionaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchOptionaLabel.Name = "searchOptionaLabel";
            this.searchOptionaLabel.Size = new System.Drawing.Size(58, 13);
            this.searchOptionaLabel.TabIndex = 15;
            this.searchOptionaLabel.Text = "Search by:";
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(8, 12);
            this.searchTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(172, 16);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "View Patient Information";
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPatientPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(693, 260);
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
