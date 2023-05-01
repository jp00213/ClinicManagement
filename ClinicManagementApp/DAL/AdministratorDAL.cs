using ClinicManagementApp.Model;
using System;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Administrator objects. 
    /// </summary>
    public class AdministratorDAL
    {
        /// <summary>
        /// Returns Person object from administrator's username
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Person GetAdminstratorByUsername(string user)
        {
            Person administrator = new Person();
            if (user == "" || user is null)
            {
                throw new ArgumentOutOfRangeException("user", "Username can't be blank or null");
            }

            string selectStatement =
                "SELECT pe.firstName, pe.lastName " +
                "FROM administrator a " +
                "JOIN person pe " +
                "ON pe.recordID = a.recordID " +
                "WHERE a.username = @username";

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
                            administrator = new Person
                            {
                                LastName = (string)(reader)["lastName"],
                                FirstName = (string)(reader)["firstName"],
                            };
                        }
                    }
                }
            }

            return administrator;
        }
    }
}
