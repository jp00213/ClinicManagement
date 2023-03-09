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
            this.CreateTabPage = new System.Windows.Forms.TabPage();
            this.DocumentTabPage = new System.Windows.Forms.TabPage();
            this.LabsTabPage = new System.Windows.Forms.TabPage();
            this.nurseTabControl.SuspendLayout();
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
            this.nurseTabControl.Location = new System.Drawing.Point(0, 54);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(800, 396);
            this.nurseTabControl.TabIndex = 0;
            // 
            // registerTabPage
            // 
            this.registerTabPage.Location = new System.Drawing.Point(4, 22);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(792, 370);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register Patient";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 22);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTabPage.Size = new System.Drawing.Size(792, 345);
            this.UpdateTabPage.TabIndex = 1;
            this.UpdateTabPage.Text = "Update Patient";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(792, 345);
            this.ViewTabPage.TabIndex = 2;
            this.ViewTabPage.Text = "View Patient";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // CreateTabPage
            // 
            this.CreateTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreateTabPage.Name = "CreateTabPage";
            this.CreateTabPage.Size = new System.Drawing.Size(792, 345);
            this.CreateTabPage.TabIndex = 3;
            this.CreateTabPage.Text = "Create Appointment";
            this.CreateTabPage.UseVisualStyleBackColor = true;
            // 
            // DocumentTabPage
            // 
            this.DocumentTabPage.Location = new System.Drawing.Point(4, 22);
            this.DocumentTabPage.Name = "DocumentTabPage";
            this.DocumentTabPage.Size = new System.Drawing.Size(792, 345);
            this.DocumentTabPage.TabIndex = 4;
            this.DocumentTabPage.Text = "Document Visit";
            this.DocumentTabPage.UseVisualStyleBackColor = true;
            // 
            // LabsTabPage
            // 
            this.LabsTabPage.Location = new System.Drawing.Point(4, 22);
            this.LabsTabPage.Name = "LabsTabPage";
            this.LabsTabPage.Size = new System.Drawing.Size(792, 345);
            this.LabsTabPage.TabIndex = 5;
            this.LabsTabPage.Text = "Labs";
            this.LabsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nurseTabControl);
            this.Name = "MainDashboard";
            this.Text = "Form1";
            this.nurseTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl nurseTabControl;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.TabPage CreateTabPage;
        private System.Windows.Forms.TabPage DocumentTabPage;
        private System.Windows.Forms.TabPage LabsTabPage;
    }
}

