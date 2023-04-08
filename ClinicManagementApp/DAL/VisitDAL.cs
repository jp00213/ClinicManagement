using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for visit objects. 
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// Get visit information list by PatientID
        /// </summary>
        /// <param name="patientIDIn">patientID</param>
        /// <returns>visit list</returns>
        public List<Visit> GetVisitInformationListByPatientID(int patientIDIn)
        {
            List<Visit> visits = new List<Visit>();
            string selectStatement =
                " select v.visitID, " +
                " 'Visit: ' + convert(varchar, v.visitDatetime, 101) + ', ' + FORMAT(v.visitDatetime, 'hh:mm tt') + ', Dr. ' + p1.lastName as visitSummary " +
                " from appointment a, visitRoutineResults v, " +
                " doctor d, person p1 " +
                " where a.appointmentID = v.appointmentID " +
                " and a.doctorID = d.doctorID " +
                " and d.recordID = p1.recordID " +
                " and a.patientID = @patientID " ;
            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit();

                            visit.VisitID = (int)(reader)["VisitID"];
                            visit.VisitSummary = (string)(reader)["visitSummary"];
                            visits.Add(visit);
                        }
                    }
                }
            }
            return visits;  
        }

        /// <summary>
        /// Get visit infomration by visitID
        /// </summary>
        /// <param name="visitIDIn">visitID</param>
        /// <returns>visit information</returns>
        public Visit GetVisitInformationByVisitID(int visitIDIn)
        {
            Visit visit = new Visit();
            string selectStatement =
                "select a.appointmentID, v.visitID, v.visitDatetime, " +
                "p1.lastName as doctorLastName, p1.firstName as doctorFirstName, d.doctorID, n.nurseID, " +
                "p2.lastName as nurseLastName, p2.firstName as nurseFirstName, " +
                "p3.lastName as patientLastName, p3.firstName as patientFirstname, " +
                " CONVERT(VARCHAR(20), CAST( round( v.height, 0) as int) /12) + '''' + CONVERT(VARCHAR(20),CAST( round( v.height, 0) as int) %12) as formattedHeight , " +
                "v.height, v.weight, v.bloodPressureSystolic, v.bloodPressureDiastolic, v.bodyTemperature, v.pulse, v.symptoms, a.reason, isnull(initialDiagnoses, '') as initialDiagnoses, isnull(finalDiagnoses, '') as finalDiagnoses, p.patientID, " +
                " 'Visit: ' + convert(varchar, v.visitDatetime, 101) + ', ' + FORMAT(v.visitDatetime, 'hh:mm tt') + ', Dr. ' + p1.lastName as visitSummary " +
                "from appointment a, visitRoutineResults v, " +
                "doctor d, person p1, " +
                "nurse n, person p2, " +
                "patient p, person p3 " +
                "where a.appointmentID = v.appointmentID " +
                "and a.doctorID = d.doctorID " +
                "and d.recordID = p1.recordID " +
                "and v.nurseID = n.nurseID " +
                "and n.recordID = p2.recordID " +
                "and a.patientID = p.patientID " +
                "and p.recordID = p3.recordID " +
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
                            visit.AppointmentID = (int)(reader)["appointmentID"];
                            visit.VisitID = (int)(reader)["VisitID"];
                            visit.VisitDatetime = (DateTime)(reader)["visitDatetime"];
                            visit.DoctorLastName = (string)(reader)["doctorLastName"];
                            visit.DoctorFirstName = (string)(reader)["doctorFirstName"];
                            visit.NurseLastName = (string)(reader)["nurseLastName"];
                            visit.NurseFirstName = (string)(reader)["nurseFirstName"];
                            visit.PatientLastName = (string)(reader)["patientLastName"];
                            visit.PatientFirstName = (string)(reader)["patientFirstName"];
                            visit.Height = (decimal)(reader)["height"];
                            visit.Weight = (decimal)(reader)["weight"];
                            visit.BloodPressureSystolic = (int)(reader)["bloodPressureSystolic"];
                            visit.BloodPressureDiastolic = (int)(reader)["bloodPressureDiastolic"];
                            visit.BodyTemperature = (decimal)(reader)["bodyTemperature"];
                            visit.Pulse = (int)(reader)["pulse"];
                            visit.Symptoms = (string)(reader)["symptoms"];
                            visit.AppointmentReason = (string)(reader)["reason"];
                            visit.InitialDiagnoses = (string)(reader)["initialDiagnoses"];
                            visit.FinalDiagnoses = (string)(reader)["finalDiagnoses"];
                            visit.PatientID = (int)(reader)["patientID"];
                            visit.VisitSummary = (string)(reader)["visitSummary"];
                            visit.HeightFormatted = (string)(reader)["formattedHeight"];
                            visit.DoctorID = (int)(reader)["doctorID"];
                            visit.NurseID = (int)(reader)["nurseID"];
                        }
                    }
                }
            }
            return visit;
        }

        /// <summary>
        /// Enter final Diagnosis
        /// </summary>
        /// <param name="visitDataIn">visit data</param>
        /// <returns>true if final diagnosis entered</returns>
        public bool EnterFinalDiagnosis(Visit visitDataIn)
        {
            string updateStatement = "update visitRoutineResults " +
                "set finalDiagnoses = @finalDiagnosis " +
                "where visitID = @visitID " +
                "and finalDiagnoses is null ";
            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@visitID", visitDataIn.VisitID);
                    updateCommand.Parameters.AddWithValue("@finalDiagnosis", visitDataIn.FinalDiagnoses);

                    int updateCount = updateCommand.ExecuteNonQuery();

                    if (updateCount > 0)
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
}
