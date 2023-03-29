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
            this.documentVisitLabel = new System.Windows.Forms.Label();
            this.dateOfApptLabel = new System.Windows.Forms.Label();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 3);
            this.label1.TabIndex = 7;
            // 
            // DocumentVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.dateOfApptLabel);
            this.Controls.Add(this.documentVisitLabel);
            this.Name = "DocumentVisitUserControl";
            this.Size = new System.Drawing.Size(784, 570);
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
        private System.Windows.Forms.Label label1;
    }
}
