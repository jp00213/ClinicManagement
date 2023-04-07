using ClinicManagementApp.Model;
using System;
using System.Data.SqlClient;

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
                "(lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber, sex, ssn)" +
                "VALUES (@lastName, @firstName, @birthday, @addressStreet, @city, @state, @zip, @phoneNumber, @sex, @ssn)";
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

            insertCommand.Parameters.Add("@sex", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@sex"].Value = person.Sex;

            insertCommand.Parameters.Add("@ssn", System.Data.SqlDbType.Char);
            insertCommand.Parameters["@ssn"].Value = person.SSN;

            using (insertCommand)
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
        /// <summary>
        ///  Updates person's info in the DB
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
        /// <returns></returns>
        public bool UpdatePerson(int recordID, string lastName, string firstName, DateTime birthday, string addressStreet, string city, string state, string zip, string phone)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string updateStatement = "UPDATE person SET " + "lastName = @newLastName, " + "firstName = @newFirstName, " + "birthday = @newBirthday, " + "addressStreet = @newAddressStreet, " + "city = @newCity, " + "state = @newState, " + "zip = @newZip, " + "phoneNumber = @newPhone " + "WHERE recordID = @oldRecordID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@oldRecordID", recordID);
            updateCommand.Parameters.AddWithValue("@newLastName", lastName);
            updateCommand.Parameters.AddWithValue("@newFirstName", firstName);
            updateCommand.Parameters.AddWithValue("@newBirthday", birthday);
            updateCommand.Parameters.AddWithValue("@newAddressStreet", addressStreet);
            updateCommand.Parameters.AddWithValue("@newCity", city);
            updateCommand.Parameters.AddWithValue("@newState", state);
            updateCommand.Parameters.AddWithValue("@newZip", zip);
            updateCommand.Parameters.AddWithValue("@newPhone", phone);

            using (updateCommand)
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('person') FROM person";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                using (selectCommand)
                {
                    int count = updateCommand.ExecuteNonQuery(); ;
                    return count > 0;
                }
            }
        }
    }
}
