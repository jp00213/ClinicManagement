using System;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The LabTest model class.
    /// </summary>
    public class LabTest
    {
        public int VisitID { get; set; }

        public int TestCode { get; set; }

        public DateTime TestDate { get; set; } //date test was performed

        public string Result { get; set; }

        public string TestName { get; set; }

        public int ResultIsNormal { get; set; }
        public DateTime DateOrdered { get; set; } //date test was ordered (the date of the visit)

        /// <summary>
        /// Default constructor
        /// </summary>
        public LabTest()
        {

        }

        /// <summary>
        /// Overloaded lab test constructor
        /// </summary>
        /// <param name="visitID"></param>
        /// <param name="testCode"></param>
        /// <param name="testDate"></param>
        /// <param name="result"></param>
        /// <param name="testName"></param>
        /// <param name="resultIsNormal"></param>
        /// <param name="dateOrdered"></param>
        public LabTest(int visitID, int testCode, DateTime testDate, string result, string testName, int resultIsNormal, DateTime dateOrdered)
        {
            VisitID = visitID;
            TestCode = testCode;
            TestDate = testDate;
            Result = result;
            TestName = testName;
            ResultIsNormal = resultIsNormal;
            DateOrdered = dateOrdered;
        }
    }

    
}
