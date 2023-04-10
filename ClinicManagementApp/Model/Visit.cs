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
        public int DoctorID { get; set; }

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

        /// <summary>
        /// Default visit constructor
        /// </summary>
        public Visit()
        {

        }
        
        /// <summary>
        /// Overloaded visit constructor
        /// </summary>
        /// <param name="visitID"></param>
        /// <param name="appointmentID"></param>
        /// <param name="nurseID"></param>
        /// <param name="visitDatetime"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="bloodPressureDiastolic"></param>
        /// <param name="bloodPressureSystolic"></param>
        /// <param name="bodyTemperature"></param>
        /// <param name="pulse"></param>
        /// <param name="symptoms"></param>
        /// <param name="initialDiagnoses"></param>
        /// <param name="finalDiagnoses"></param>
        public Visit(int visitID, int appointmentID, int nurseID, DateTime visitDatetime, decimal height, decimal weight, int bloodPressureDiastolic, int bloodPressureSystolic, decimal bodyTemperature, int pulse, string symptoms, string initialDiagnoses, string finalDiagnoses)
        {
            VisitID = visitID;
            AppointmentID = appointmentID;
            NurseID = nurseID;
            VisitDatetime = visitDatetime;
            Height = height;
            Weight = weight;
            BloodPressureDiastolic = bloodPressureDiastolic;
            BloodPressureSystolic = bloodPressureSystolic;
            BodyTemperature = bodyTemperature;
            Pulse = pulse;
            Symptoms = symptoms;
            InitialDiagnoses = initialDiagnoses;
            FinalDiagnoses = finalDiagnoses;
            
        }
    }
}
