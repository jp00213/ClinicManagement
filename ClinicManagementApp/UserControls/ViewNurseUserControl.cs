using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class ViewNurseUserControl : UserControl
    {
        private readonly NurseController _nurseController;
        public ViewNurseUserControl()
        {
            InitializeComponent();
            _nurseController = new NurseController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            var firstName = this.searchFirstNameTextBox.Text;
            var lastName = this.searchLastNameTextBox.Text;
            List<Nurse> nurseList = _nurseController.GetNurseByName(firstName, lastName);

            this.nurseDataGridView.DataSource = nurseList;

            if (nurseList.Count == 0)
            {
                messageLabel.Text = "No nurses found.";
            }
        }

        private void NurseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (nurseDataGridView.SelectedRows.Count > 0)
                {
                    var nurseID = nurseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    Nurse nurse = this._nurseController.GetNurseByID(Int32.Parse(nurseID));

                    if (nurse != null)
                    {
                        nurseBindingSource1.DataSource = nurse;
                        nurseBindingSource1.ResetBindings(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
