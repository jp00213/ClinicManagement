﻿namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Doctor model class.
    /// </summary>
    public class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string Specialty { get; set; }
        /// <summary>
        /// Doctor constructor.
        /// </summary>

        public string Speciality { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public Doctor()
        {

        }

        /// <summary>
        /// Doctor constructor.
        /// </summary>
        /// <param name="doctorID"> doctorID of an doctor</param>
        public Doctor(int doctorID)
        {
            this.DoctorID = doctorID;
        }


        
    }
}
