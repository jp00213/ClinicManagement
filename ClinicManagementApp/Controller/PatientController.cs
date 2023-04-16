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
        private readonly PersonDAL _personDAL;

        /// <summary>
        /// Create a PatientController object.
        /// </summary>
        public PatientController()
        {
            this._patientDAL = new PatientDAL();
            this._personDAL = new PersonDAL();
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

        /// <summary>
        /// Adds a patients to the DB
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Boolean AddPatient(Person person)
        {
            if (person == null) throw new ArgumentNullException("Person cannot be null.");
            return this._personDAL.AddPersonAsPatient(person);
        }

        /// <summary>
        /// Updates patients in DB
        /// </summary>
        /// <param name="recordID"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="birthday"></param>
        /// <param name="addressStreet"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="sex"></param>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool UpdatePatient(int recordID, string lastName, string firstName, DateTime birthday, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn)
        {
            return this._personDAL.UpdatePerson(recordID, lastName, firstName, birthday, addressStreet, city, state, zip, phone, sex, ssn);
        }

        /// Input check: if first and last name are empty, search by dob;
        /// if dob is empty, search by first and last name;
        /// if first name is empty, search by last name and dob.
        /// </summary>
        /// <param name="firstNameIn">first name of patient</param>
        /// <param name="lastNameIn">last name of patient</param>
        /// <param name="dobIn">birthday of patient</param>
        /// <returns>patient</returns>
        public List<Patient> GetPatientByInputsCheck(string firstNameIn, string lastNameIn, DateTime dobIn)
        {
            if ((firstNameIn == string.Empty) && (lastNameIn == string.Empty))
            {
                return this._patientDAL.GetPatientByDobOnly(dobIn);
            }
            else if ((firstNameIn != string.Empty) && (lastNameIn != string.Empty))
            {
                return this._patientDAL.GetPatientByLastAndFirstName(firstNameIn, lastNameIn);
            }
            else
            {
                return this._patientDAL.GetPatientByLastNameAndDOB(lastNameIn, dobIn);
            }

        }

        /// <summary>
        /// Returns patients by appointment date
        /// </summary>
        /// <param name="appointmentDate"></param>
        /// <returns></returns>
        public List<Patient> GetPatientByAppointmentDate(DateTime appointmentDate)
        {
            return _patientDAL.GetPatientByAppointmentDate(appointmentDate);
        }

        /// <summary>
        /// Get patients by visit Date per search requirement
        /// </summary>
        /// <param name="visitDate">visit date</param>
        /// <returns>patient list</returns>
        public List<PatientVisit> GetPatientsByVisitDate(DateTime visitDate) => this._patientDAL.GetPatientsByVisitDate(visitDate);


    }
}
