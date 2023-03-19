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
            this.SuspendLayout();
            // 
            // searchPatientPanel
            // 
            this.searchPatientPanel.Location = new System.Drawing.Point(3, 0);
            this.searchPatientPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientPanel.Name = "searchPatientPanel";
            this.searchPatientPanel.Size = new System.Drawing.Size(565, 174);
            this.searchPatientPanel.TabIndex = 0;
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPatientPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(555, 266);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPatientPanel;
    }
}
