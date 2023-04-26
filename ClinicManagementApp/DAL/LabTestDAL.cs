using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for labTest objects. 
    /// </summary>
    public class LabTestDAL
    {
        /// <summary>
        /// Get lab test list by visitID
        /// </summary>
        /// <param name="visitIDIn">Visit ID</param>
        /// <returns>lab tests</returns>
        public List<LabTest> GetLabTestListByVisitID(int visitIDIn)
        {
            List<LabTest> labTests = new List<LabTest>();
            string selectStatement =
                "select v.visitID, v.testCode, v.resultIsNormal, v.testDate, t.name, v.result, vi.visitDatetime " +
                "FROM visit_has_test v " +
                "join test t " +
                "on v.testCode = t.testCode " +
                "join visitRoutineResults vi " +
                "on vi.visitID = v.visitID " +
                "and v.visitID = @visitID ";
            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@visitID", visitIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTest theLabTest = new LabTest();

                            theLabTest.VisitID = (int)(reader)["visitID"];
                            theLabTest.TestCode = (int)(reader)["testCode"];
                            theLabTest.Result = (string)(reader)["result"];
                            theLabTest.ResultIsNormal = (byte)(reader)["resultIsNormal"];
                            theLabTest.TestDate = (DateTime)(reader)["testDate"];
                            theLabTest.TestName = (string)(reader)["name"];
                            theLabTest.DateOrdered = (DateTime)(reader)["visitDateTime"];

                            labTests.Add(theLabTest);
                        }
                    }
                }
            }
            return labTests;
        }

        /// <summary>
        /// Gets the full lists of available lab tests
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTests()
        {
            List<LabTest> labTests = new List<LabTest>();
            LabTest labTest = new LabTest();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "select * " +
                " from test " +
                " order by name ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        labTest = new LabTest
                        {
                            TestCode = (int)(reader)["testCode"],
                            TestName = (string)(reader)["name"],

                        };
                        labTests.Add(labTest);
                    }
                }
            }
            return labTests;
        }

        /// <summary>
        /// Get most performed tests during dates
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>lab tests</returns>
        public List<LabTest> GetMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            List<LabTest> labTests = new List<LabTest>();
            LabTest labTest = new LabTest();

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("dbo.spGetMostPerformedTestsDuringDates", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                command.Connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        labTest = new LabTest
                        {
                            TestCode = (int)(reader)["testCode"],
                            TestName = (string)(reader)["testName"],
                            TimesPerformed = (int)(reader)["timesPerformed"],
                            AllTestTotal = (int)(reader)["allTestTotal"],
                            PercentOfAllTests = (string)(reader)["percentOfAllTests"],
                            NormalCount = (int)(reader)["normalCount"],
                            AbnormalCount = (int)(reader)["abnormalCount"],
                            Age18To29 = (string)(reader)["age18To29"],
                            Age30To39 = (string)(reader)["age30To39"],
                            OtherAges = (string)(reader)["otherAges"],
                        };
                        labTests.Add(labTest);
                    }
                }

            }
            return labTests;
            
        }

        /// Update lab test details
        /// </summary>
        /// <returns>success message</returns>
        /// <param name="test"> test object to be updated</param>
        public bool UpdateLabTest(LabTest test)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement =
                "UPDATE visit_has_test " +
                "SET resultIsNormal = @resultIsNormal, testDate = @datePerformed, " +
                "result = @result " +
                "WHERE visitID = @visitID " +
                "AND testCode = @testCode";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@visitID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@visitID"].Value = test.VisitID;

            insertCommand.Parameters.Add("@datePerformed", System.Data.SqlDbType.DateTime);
            insertCommand.Parameters["@datePerformed"].Value = test.TestDate;

            insertCommand.Parameters.Add("@result", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@result"].Value = test.Result;

            insertCommand.Parameters.Add("@testCode", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@testCode"].Value = test.TestCode;

            insertCommand.Parameters.Add("@resultIsNormal", System.Data.SqlDbType.TinyInt);
            insertCommand.Parameters["@resultIsNormal"].Value = test.ResultIsNormal;

            using (insertCommand)
            {
                connection.Open();
                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        /// <summary>
        /// Adds new test ordered from visit
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public bool AddLabTest(LabTest test)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO visit_has_test " +
                "(visitID, testCode, testDate, result, resultIsNormal) " +
                "VALUES (@visitID, @testCode, @testDate, @result, @resultIsNormal)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@visitID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@visitID"].Value = test.VisitID;

            insertCommand.Parameters.Add("@testCode", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@testCode"].Value = test.TestCode;

            insertCommand.Parameters.Add("@testDate", System.Data.SqlDbType.DateTime);
            insertCommand.Parameters["@testDate"].Value = test.TestDate;

            insertCommand.Parameters.Add("@result", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@result"].Value = test.Result;

            insertCommand.Parameters.Add("@resultIsNormal", System.Data.SqlDbType.TinyInt);
            insertCommand.Parameters["@resultIsNormal"].Value = test.ResultIsNormal;

            using (insertCommand)
            {
                connection.Open();
                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
