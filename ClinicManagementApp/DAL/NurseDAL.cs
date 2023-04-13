using ClinicManagementApp.Model;
using System;
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

    }
}
