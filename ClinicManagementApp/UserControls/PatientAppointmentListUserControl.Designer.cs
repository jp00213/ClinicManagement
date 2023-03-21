namespace ClinicManagementApp.UserControls
{
    partial class PatientAppointmentListUserControl
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Appointments UC";
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(23, 23);
            this.patientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(57, 13);
            this.patientIDLabel.TabIndex = 5;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientIDTextBox.Location = new System.Drawing.Point(93, 23);
            this.patientIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(67, 13);
            this.patientIDTextBox.TabIndex = 3;
            // 
            // PatientAppointmentListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientAppointmentListUserControl";
            this.Size = new System.Drawing.Size(615, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.TextBox patientIDTextBox;
    }
}
