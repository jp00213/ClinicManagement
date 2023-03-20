namespace ClinicManagementApp
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nurseTabControl = new System.Windows.Forms.TabControl();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.UpdateTabPage = new System.Windows.Forms.TabPage();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateTabPage = new System.Windows.Forms.TabPage();
            this.DocumentTabPage = new System.Windows.Forms.TabPage();
            this.LabsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPatientIDLabel = new System.Windows.Forms.Label();
            this.searchPatientUserControl1 = new ClinicManagementApp.UserControls.SearchPatientUserControl();
            this.patientDisplayInfoUserControl1 = new ClinicManagementApp.UserControls.PatientDisplayInfoUserControl();
            this.createAppointmentUserControl1 = new ClinicManagementApp.UserControls.CreateAppointmentUserControl();
            this.nurseTabControl.SuspendLayout();
            this.ViewTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CreateTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTabControl
            // 
            this.nurseTabControl.Controls.Add(this.registerTabPage);
            this.nurseTabControl.Controls.Add(this.UpdateTabPage);
            this.nurseTabControl.Controls.Add(this.ViewTabPage);
            this.nurseTabControl.Controls.Add(this.CreateTabPage);
            this.nurseTabControl.Controls.Add(this.DocumentTabPage);
            this.nurseTabControl.Controls.Add(this.LabsTabPage);
            this.nurseTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nurseTabControl.Location = new System.Drawing.Point(0, 71);
            this.nurseTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(862, 630);
            this.nurseTabControl.TabIndex = 0;
            // 
            // registerTabPage
            // 
            this.registerTabPage.Location = new System.Drawing.Point(4, 27);
            this.registerTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.registerTabPage.Size = new System.Drawing.Size(854, 599);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register Patient";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 27);
            this.UpdateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Size = new System.Drawing.Size(854, 599);
            this.UpdateTabPage.TabIndex = 1;
            this.UpdateTabPage.Text = "Update Patient";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ViewTabPage.Location = new System.Drawing.Point(4, 27);
            this.ViewTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(854, 599);
            this.ViewTabPage.TabIndex = 2;
            this.ViewTabPage.Text = "View Patient";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.47292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.527076F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchPatientUserControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientDisplayInfoUserControl1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.04781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CreateTabPage
            // 
            this.CreateTabPage.Controls.Add(this.createAppointmentUserControl1);
            this.CreateTabPage.Location = new System.Drawing.Point(4, 27);
            this.CreateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTabPage.Name = "CreateTabPage";
            this.CreateTabPage.Size = new System.Drawing.Size(854, 599);
            this.CreateTabPage.TabIndex = 3;
            this.CreateTabPage.Text = "Create Appointment";
            this.CreateTabPage.UseVisualStyleBackColor = true;
            // 
            // DocumentTabPage
            // 
            this.DocumentTabPage.Location = new System.Drawing.Point(4, 27);
            this.DocumentTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentTabPage.Name = "DocumentTabPage";
            this.DocumentTabPage.Size = new System.Drawing.Size(854, 599);
            this.DocumentTabPage.TabIndex = 4;
            this.DocumentTabPage.Text = "Document Visit";
            this.DocumentTabPage.UseVisualStyleBackColor = true;
            // 
            // LabsTabPage
            // 
            this.LabsTabPage.Location = new System.Drawing.Point(4, 27);
            this.LabsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.LabsTabPage.Name = "LabsTabPage";
            this.LabsTabPage.Size = new System.Drawing.Size(854, 599);
            this.LabsTabPage.TabIndex = 5;
            this.LabsTabPage.Text = "Labs";
            this.LabsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currentPatientIDLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 24);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Patient #:";
            // 
            // currentPatientIDLabel
            // 
            this.currentPatientIDLabel.AutoSize = true;
            this.currentPatientIDLabel.Location = new System.Drawing.Point(149, 4);
            this.currentPatientIDLabel.Name = "currentPatientIDLabel";
            this.currentPatientIDLabel.Size = new System.Drawing.Size(18, 18);
            this.currentPatientIDLabel.TabIndex = 1;
            this.currentPatientIDLabel.Text = "--";
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Location = new System.Drawing.Point(2, 32);
            this.searchPatientUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(826, 215);
            this.searchPatientUserControl1.TabIndex = 2;
            // 
            // patientDisplayInfoUserControl1
            // 
            this.patientDisplayInfoUserControl1.Location = new System.Drawing.Point(4, 292);
            this.patientDisplayInfoUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.patientDisplayInfoUserControl1.Name = "patientDisplayInfoUserControl1";
            this.patientDisplayInfoUserControl1.Size = new System.Drawing.Size(824, 269);
            this.patientDisplayInfoUserControl1.TabIndex = 3;
            // 
            // createAppointmentUserControl1
            // 
            this.createAppointmentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentUserControl1.Location = new System.Drawing.Point(14, 4);
            this.createAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.createAppointmentUserControl1.Name = "createAppointmentUserControl1";
            this.createAppointmentUserControl1.Size = new System.Drawing.Size(836, 586);
            this.createAppointmentUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 701);
            this.Controls.Add(this.nurseTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management Application";
            this.nurseTabControl.ResumeLayout(false);
            this.ViewTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CreateTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl nurseTabControl;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.TabPage CreateTabPage;
        private System.Windows.Forms.TabPage DocumentTabPage;
        private System.Windows.Forms.TabPage LabsTabPage;
        private System.Windows.Forms.TabPage registerTabPage;
        private UserControls.CreateAppointmentUserControl createAppointmentUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentPatientIDLabel;
        private System.Windows.Forms.Label label1;
        private UserControls.SearchPatientUserControl searchPatientUserControl1;
        private UserControls.PatientDisplayInfoUserControl patientDisplayInfoUserControl1;
    }
}

