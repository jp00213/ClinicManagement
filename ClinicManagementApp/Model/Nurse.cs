﻿namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Nurse model class.
    /// </summary>
    public class Nurse : Person
    {
        public int NurseID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }
    }
}
