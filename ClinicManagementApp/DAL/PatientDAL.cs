using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Patient objects. 
    /// </summary>
    public class PatientDAL
    {
        /// <summary>
        /// Get all the patients from the database source.
        /// </summary>
        /// <returns>a list of patient objects based on name and dob</returns>
        /// <param name="firstName"> first name of patient</param>
        /// <param name="lastName"> last name of patient</param>
        /// <param name="dob"> dob of patient</param>
        public List<Patient> GetPatientByNameDOB(string firstName, string lastName, DateTime dob)
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Patient pa " +
                "JOIN person pe " +
                "ON pa.recordID = pe.recordID " +
                "WHERE pe.firstName like @firstName " + 
                "AND pe.lastName like @lastName " + 
                "AND pe.birthday = @dob";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@firstName"].Value = firstName + "%";

            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@lastName"].Value = lastName + "%";

            selectCommand.Parameters.Add("@dob", System.Data.SqlDbType.Date);
            selectCommand.Parameters["@dob"].Value = dob;

            using (selectCommand)
            {
                connection.Open();
                using(SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        patient = new Patient
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"]
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Get a patient from the database source.
        /// </summary>
        /// <returns>a patient object based on patientID</returns>
        /// <param name="patientID"> first name of patient</param>
        public Patient GetPatientByID(int patientID)
        {
            Patient patient = new Patient();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Patient pa " +
                "JOIN person pe " +
                "ON pa.recordID = pe.recordID " +
                "WHERE pa.patientID = @patientID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@patientID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@patientID"].Value = patientID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patient = new Patient
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"],
                            Sex = (string)(reader)["sex"],
                            SSN = (string)(reader)["ssn"]
                        };
                    }
                }
            }
            return patient;
        }

        /// <summary>
        /// Creates a new patient based on the persons record number from the person table
        /// </summary>
        /// <param name="person"></param>
        /// <returns>New patients ID</returns>
        public int AddPatient(int personID)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement = "INSERT INTO patient " +
                "(recordID) VALUES (@recordID)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@recordID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@recordID"].Value = personID;

            using(insertCommand)
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('patient') FROM patient";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                using (selectCommand)
                {
                    int patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return patientID;
                }
            }
        }


        /// <summary>
        /// Get patient by last and first name per search requirement
        /// </summary>
        /// <param name="firstNameIn">first name of patient</param>
        /// <param name="lastNameIn">last name of patient</param>
        /// <returns>patient list</returns>
        public List<Patient> GetPatientByLastAndFirstName(string firstNameIn, string lastNameIn)
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Patient a " +
                "JOIN Person e " +
                "ON a.recordID = e.recordID " +
                "WHERE e.firstName = @firstName " +
                "AND e.lastName = @lastName ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@firstName", firstNameIn);
            selectCommand.Parameters.AddWithValue("@lastName", lastNameIn);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patient = new Patient
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"]
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;

        }

        /// <summary>
        /// Get patient by last name and birthday per search requirement
        /// </summary>
        /// <param name="lastNameIn">last name of patient</param>
        /// <param name="dobIn">birthday of patient</param>
        /// <returns>patient list</returns>
        public List<Patient> GetPatientByLastNameAndDOB(string lastNameIn, DateTime dobIn)
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Patient a " +
                "JOIN Person e " +
                "ON a.recordID = e.recordID " +
                "WHERE e.lastName = @lastName " +
                "AND e.birthday = @dob ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@lastName", lastNameIn);
            selectCommand.Parameters.AddWithValue("@dob", dobIn);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patient = new Patient
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"]
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Get patient by DOB per search requirement
        /// </summary>
        /// <param name="dobIn">birthday of patient</param>
        /// <returns>patient list</returns>
        public List<Patient> GetPatientByDobOnly(DateTime dobIn)
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM Patient a " +
                "JOIN Person e " +
                "ON a.recordID = e.recordID " +
                "WHERE e.birthday = @dob ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@dob",dobIn);
           
            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patient = new Patient
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"]
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }

        /// <summary>
        /// Get patients by visit Date per search requirement
        /// </summary>
        /// <param name="visitDate">visit date</param>
        /// <returns>patient list</returns>
        public List<PatientVisit> GetPatientsByVisitDate(DateTime visitDate)
        {
            List<PatientVisit> patients = new List<PatientVisit>();
            PatientVisit patient = new PatientVisit();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                  "SELECT pe.firstName, pe.lastName, pe.birthday, pe.phoneNumber, pe.addressStreet, pe.recordID, p.patientID, " +
                  "pe.city, pe.state, pe.zip, v.visitID " +
                  "FROM visitRoutineResults v " +
                  "join appointment a " +
                  "on a.appointmentID = v.appointmentID " +
                  "join patient p " +
                  "on p.patientID = a.patientID " +
                  "join person pe " +
                  "on pe.recordID = p.recordID " +
                  "where v.visitDatetime between @visitDate and @visitDateEnd";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@visitDate", System.Data.SqlDbType.Date);
            selectCommand.Parameters["@visitDate"].Value = visitDate;

            selectCommand.Parameters.Add("@visitDateEnd", System.Data.SqlDbType.DateTime);
            selectCommand.Parameters["@visitDateEnd"].Value = visitDate.Add(new TimeSpan(23, 59, 59));

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patient = new PatientVisit
                        {
                            RecordID = (int)(reader)["recordID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            DateOfBirth = (DateTime)(reader)["birthday"],
                            AddressStreet = (string)(reader)["addressStreet"],
                            City = (string)(reader)["city"],
                            State = (string)(reader)["state"],
                            Zip = (string)(reader)["zip"],
                            Phone = (string)(reader)["phoneNumber"],
                            PatientID = (int)(reader)["patientID"],
                            VisitID = (int)(reader)["visitID"]
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }

    }

}
