using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the PatientDAL and the View.
    /// </summary>
    public class PatientController
    {
        private readonly PatientDAL _patientDAL;

        /// <summary>
        /// Create a PatientController object.
        /// </summary>
        public PatientController()
        {
            this._patientDAL = new PatientDAL();
        }

        /// <summary>
        /// Get all the patients from the database source.
        /// </summary>
        /// <returns>a list of patient objects based on name and dob</returns>
        /// <param name="firstName"> first name of patient</param>
        /// <param name="lastName"> last name of patient</param>
        /// <param name="dob"> dob of patient</param>
        public List<Patient> GetPatientByNameDOB(string firstName, string lastName, DateTime dob)
        {
            return this._patientDAL.GetPatientByNameDOB(firstName, lastName, dob);
        }

        /// <summary>
        /// Get a patient from the database source.
        /// </summary>
        /// <returns>a patient object based on patientID</returns>
        /// <param name="patientID"> first name of patient</param>
        public Patient GetPatientByID(int patientID) => this._patientDAL.GetPatientByID(patientID);
    }
}
