﻿using ClinicManagementApp.Model;
using System;
using System.Data.SqlClient;
using System.Text;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// Defines the DAL for the Person object
    /// </summary>
    public class PersonDAL
    {
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
        public bool UpdatePerson(int recordID, string lastName, string firstName, DateTime birthday, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn)
        {
            bool result = false;
            int affectedRecords = 0;
            string updateStatement = "UPDATE person SET " + "lastName = @newLastName, " + "firstName = @newFirstName, " + 
                "birthday = @newBirthday, " + "addressStreet = @newAddressStreet, " + "city = @newCity, " + "state = @newState, " 
                + "zip = @newZip, " + "phoneNumber = @newPhone, sex = @newSex, ssn = @newSSN " + "WHERE recordID = @oldRecordID";
            string selectStatement = "SELECT @@ROWCOUNT";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                        {
                            updateCommand.Transaction = transaction;

                            updateCommand.Parameters.AddWithValue("@oldRecordID", recordID);
                            updateCommand.Parameters.AddWithValue("@newLastName", lastName);
                            updateCommand.Parameters.AddWithValue("@newFirstName", firstName);
                            updateCommand.Parameters.AddWithValue("@newBirthday", birthday);
                            updateCommand.Parameters.AddWithValue("@newAddressStreet", addressStreet);
                            updateCommand.Parameters.AddWithValue("@newCity", city);
                            updateCommand.Parameters.AddWithValue("@newState", state);
                            updateCommand.Parameters.AddWithValue("@newZip", zip);
                            updateCommand.Parameters.AddWithValue("@newPhone", phone);
                            updateCommand.Parameters.AddWithValue("@newSex", sex);
                            if (ssn == "")
                            {
                                updateCommand.Parameters.AddWithValue("@newSSN", DBNull.Value);
                            }
                            else
                            {
                                updateCommand.Parameters.AddWithValue("@newSSN", ssn);
                            }

                            updateCommand.ExecuteNonQuery();

                            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                            selectCommand.Transaction = transaction;
                            using (selectCommand)
                            {
                                affectedRecords = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }

                            result = affectedRecords > 0;
                            transaction.Commit();
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
            return result;
        }

        /// <summary>
        ///  Creates person as a patient in the DB
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Boolean AddPersonAsPatient(Person person)
        {
            Boolean result = false;
            int record = 0;
            int affectedRecords = 0;

            string insertStatementPerson = "INSERT INTO person " +
                "(lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber, sex, ssn) " +
                "VALUES (@lastName, @firstName, @birthday, @addressStreet, @city, @state, @zip, @phoneNumber, @sex, @ssn)";
            string selectStatementRecordID = "SELECT IDENT_CURRENT('person') FROM person";
            string insertStatementPatient = "INSERT INTO patient (recordID) VALUES (@recordID)";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPerson, connection))
                        {
                            insertCommand.Transaction = transaction;

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
                            if (person.SSN == "")
                            {
                                insertCommand.Parameters["@ssn"].Value = DBNull.Value;
                            }
                            else
                            {
                                insertCommand.Parameters["@ssn"].Value = person.SSN;
                            }

                            insertCommand.ExecuteNonQuery();

                            SqlCommand selectCommand = new SqlCommand(selectStatementRecordID, connection);
                            selectCommand.Transaction = transaction;
                            using (selectCommand)
                            {
                                record = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPatient, connection))
                        {
                            insertCommand.Transaction = transaction;

                            insertCommand.Parameters.Add("@recordID", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@recordID"].Value = record;

                            affectedRecords = insertCommand.ExecuteNonQuery();
                        }

                        result = affectedRecords > 0;
                        transaction.Commit();
                    } catch
                    {
                        transaction.Rollback();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Adds a nurse to the database with status set to active
        /// </summary>
        /// <param name="person"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AddPersonAsNurse(Person person, string username, string password)
        {
            Boolean result = false;
            int record = 0;
            int affectedRecords = 0;
            string hashedPassword = this.HashPassword(password);

            string insertStatementAccount = "INSERT INTO account (username, password) " +
                "VALUES (@username, @password)";
            string insertStatementPerson = "INSERT INTO person " +
                "(lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber, sex, ssn) " +
                "VALUES (@lastName, @firstName, @birthday, @addressStreet, @city, @state, @zip, @phoneNumber, @sex, @ssn)";
            string selectStatementRecordID = "SELECT IDENT_CURRENT('person') FROM person";
            string insertStatementPatient = "INSERT INTO nurse (recordID, username, activeStatus) " +
                "VALUES (@recordID, @username, 1)";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertStatementAccount, connection))
                        {
                            insertCommand.Transaction = transaction;

                            insertCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                            insertCommand.Parameters["@username"].Value = username;

                            insertCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                            insertCommand.Parameters["@password"].Value = hashedPassword;

                            insertCommand.ExecuteNonQuery();

                        }

                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPerson, connection))
                        {
                            insertCommand.Transaction = transaction;

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
                            if (person.SSN == "")
                            {
                                insertCommand.Parameters["@ssn"].Value = DBNull.Value;
                            }
                            else
                            {
                                insertCommand.Parameters["@ssn"].Value = person.SSN;
                            }

                            insertCommand.ExecuteNonQuery();

                            SqlCommand selectCommand = new SqlCommand(selectStatementRecordID, connection);
                            selectCommand.Transaction = transaction;
                            using (selectCommand)
                            {
                                record = Convert.ToInt32(selectCommand.ExecuteScalar());
                            }
                        }

                        using (SqlCommand insertCommand = new SqlCommand(insertStatementPatient, connection))
                        {
                            insertCommand.Transaction = transaction;

                            insertCommand.Parameters.Add("@recordID", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@recordID"].Value = record;

                            insertCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                            insertCommand.Parameters["@username"].Value = username;

                            affectedRecords = insertCommand.ExecuteNonQuery();
                        }

                        result = affectedRecords > 0;
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Hashes a given password using SHA512, returns hashed password as a string
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string HashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
    }
}
