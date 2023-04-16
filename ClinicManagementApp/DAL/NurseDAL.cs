using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Nurse objects. 
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// Returns full name of nurse by username
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Nurse full name</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string GetNurseName(string user)
        {
            if (user == "" || user is null)
            {
                throw new ArgumentOutOfRangeException("user", "Username can't be blank or null");
            }

            string fullName = "";

            string selectStatement =
                "SELECT firstName, lastName " +
                "FROM Person JOIN Nurse ON Person.recordID = Nurse.recordID " +
                "WHERE Nurse.Username = @Username";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fullName = reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                        }
                    }
                }
            }

            return fullName;
        }

        /// <summary>
        /// Get nurse by id
        /// </summary>
        /// /// <param name="nurseID">id of nurse</param>
        /// <returns>Nurse</returns>
        public Nurse GetNurseByID(int nurseID)
        {
            Nurse nurse = new Nurse();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT d.nurseID, pe.firstName, pe.lastName " +
                "FROM nurse d " +
                "JOIN person pe " +
                "ON d.recordID = pe.recordID " +
                "WHERE d.nurseID = @nurseID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@nurseID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@nurseID"].Value = nurseID;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nurse = new Nurse
                        {
                            NurseID = (int)(reader)["nurseID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                        };
                    }
                }
            }
            return nurse;
        }

        /// <summary>
        /// Gets the current nurse based on who is logged in
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Nurse GetNurseByUsername(string user)
        {
            Nurse nurse = new Nurse();
            if (user == "" || user is null)
            {
                throw new ArgumentOutOfRangeException("user", "Username can't be blank or null");
            }

            string selectStatement =
                "SELECT n.nurseID, pe.firstName, pe.lastName " +
                "FROM nurse n " +
                "JOIN person pe " +
                "ON n.recordID = pe.recordID " +
                "WHERE n.username = @username";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = user;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse = new Nurse
                            {
                                NurseID = (int)(reader)["nurseID"],
                                LastName = (string)(reader)["lastName"],
                                FirstName = (string)(reader)["firstName"],
                            };
                        }
                    }
                }
            }

            return nurse;
        }

        /// <summary>
        /// Get all the nurses from the database source.
        /// </summary>
        /// <returns>a list of nurse objects based on name and dob</returns>
        /// <param name="firstName"> first name of nurse</param>
        /// <param name="lastName"> last name of nurse</param>
        public List<Nurse> GetNurseByName(string firstName, string lastName)
        {
            List<Nurse> nurses = new List<Nurse>();
            Nurse nurse = new Nurse();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT * " +
                "FROM nurse n " +
                "JOIN person pe " +
                "ON n.recordID = pe.recordID " +
                "WHERE pe.firstName like @firstName " +
                "AND pe.lastName like @lastName ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@firstName"].Value = firstName + "%";

            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            selectCommand.Parameters["@lastName"].Value = lastName + "%";

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nurse = new Nurse
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
                            NurseID = (int)(reader)["nurseID"],
                            Username = (string)(reader)["username"],
                            IsActive = Convert.ToInt32((byte)(reader["activeStatus"])),
                            Sex = (reader)["sex"] != DBNull.Value ? (string)(reader)["sex"] : null,
                            SSN = (reader)["ssn"] != DBNull.Value ? (string)(reader)["ssn"] : null
                        };
                        nurses.Add(nurse);
                    }
                }
            }
            return nurses;
        }

    }
}
