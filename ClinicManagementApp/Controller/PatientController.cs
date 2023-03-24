﻿using ClinicManagementApp.DAL;
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
        private PersonDAL _personDAL;

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
        public int AddPatient(Person person)
        {
            if (person == null) throw new ArgumentNullException("Person cannot be null.");
            int personID = this.AddPerson(person);
            return this._patientDAL.AddPatient(personID);
        }

        /// <summary>
        /// Adds a person to the DB
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int AddPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException("Person cannot be null.");
            return this._personDAL.AddPerson(person);
        }

        public bool UpdatePatient(int recordID, string lastName, string firstName, DateTime birthday, string addressStreet, string city, string state, string zip, string phone)
        {
            return this._personDAL.UpdatePerson(recordID, lastName, firstName, birthday, addressStreet, city, state, zip, phone);

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

    }
}
