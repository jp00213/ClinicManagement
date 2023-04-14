﻿using System;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Administrator objects. 
    /// </summary>
    public class AdministratorDAL
    {
        /// <summary>
        /// Returns full name of administrator by username
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Nurse full name</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string GetAdministratorName(string user)
        {
            if (user == "" || user is null)
            {
                throw new ArgumentOutOfRangeException("user", "Username can't be blank or null");
            }

            string fullName = "";

            string selectStatement =
                "SELECT firstName, lastName " +
                "FROM Person JOIN Administrator ON Person.recordID = Administrator.recordID " +
                "WHERE Administrator.Username = @Username";

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

    }
}
