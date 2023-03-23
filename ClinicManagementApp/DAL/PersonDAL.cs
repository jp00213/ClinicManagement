using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// Defines the DAL for the Person object
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Adds a person to the person DB
        /// </summary>
        /// <param name="person"></param>
        /// <returns>new personID</returns>
        public int AddPerson(Person person)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement = "INSERT INTO person " +
                "(lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber)" +
                "VALUES (@lastName, @firstName, @birthday, @addressStreet, @city, @state, @zip, @phoneNumber)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@lastName"].Value = person.LastName;

            insertCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@firstName"].Value = person.FirstName;

            insertCommand.Parameters.Add("@birthday", System.Data.SqlDbType.Date);
            insertCommand.Parameters["@birthday"].Value = person.DateOfBirth;

            insertCommand.Parameters.Add("@addressStreet", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@addressStreet"].Value = person.AddressStreet;

            insertCommand.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@city"].Value = person.City;

            insertCommand.Parameters.Add("@state", System.Data.SqlDbType.Char);
            insertCommand.Parameters["@state"].Value = person.State;

            insertCommand.Parameters.Add("@zip", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@zip"].Value = person.Zip;

            insertCommand.Parameters.Add("@phoneNumber", System.Data.SqlDbType.Char);
            insertCommand.Parameters["@phoneNumber"].Value = person.Phone;

            using(insertCommand)
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('person') FROM person";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                using(selectCommand)
                {
                    int personID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return personID;
                }
            }
        }
    }
}
