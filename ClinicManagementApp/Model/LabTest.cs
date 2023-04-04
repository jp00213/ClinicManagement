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

        public DateTime TestDate { get; set; }

        public string Result { get; set; }

        public string TestName { get; set; }

        public int ResultIsNormal { get; set; }
    }
}
