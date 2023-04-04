using System;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Visit model class.
    /// </summary>
    public class Visit
    {
        public int VisitID { get; set; }

        public int AppointmentID { get; set; }

        public int NurseID { get; set; }

        public DateTime VisitDatetime { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public int BloodPressureDiastolic { get; set; }

        public int BloodPressureSystolic { get; set; }

        public decimal BodyTemperature { get; set; }

        public int Pulse { get; set; }  

        public string Symptoms { get; set; }

        public string InitialDiagnoses { get; set; }

        public string FinalDiagnoses { get; set; }

        public string DoctorLastName { get; set; }

        public string DoctorFirstName { get; set;}

        public string NurseLastName { get; set; }

        public string NurseFirstName { get; set;}

        public string PatientLastName { get; set; }

        public string PatientFirstName { get; set;}

        public int PatientID { get; set; }

        public string AppointmentReason { get; set; }   

        public string VisitSummary { get; set; }

        public string HeightFormatted { get; set; }

    }
}
