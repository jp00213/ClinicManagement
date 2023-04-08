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
    }
}
