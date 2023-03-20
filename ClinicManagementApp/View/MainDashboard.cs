﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void searchPatientUserControl1_PatientNumberChanged(object sender, EventArgs e)
        {
            this.currentPatientIDLabel.Text = searchPatientUserControl1.getCurrentpatientID();
        }

        /// <summary>
        /// getter current patientID selected from patientDisplayInfoUserControl
        /// </summary>
        public string ID
        {
            get { return this.currentPatientIDLabel.Text; }
        }

        private void currentPatientIDLabel_TextChanged(object sender, EventArgs e)
        {
            this.patientDisplayInfoUserControl1.ID = ID;
        }
    }
}
