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
                            PatientID = (int)(reader)["patientID"]
                        };
                    }
                }
            }
            return patient;
        }
    }
}
