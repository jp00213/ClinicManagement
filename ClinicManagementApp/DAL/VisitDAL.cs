﻿using ClinicManagementApp.Model;
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
                " select v.visitID, v.appointmentID, " +
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
                            visit.AppointmentID = (int)(reader)["appointmentID"];
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
                "and finalDiagnoses is null " +
                "or visitID = @visitID and finalDiagnoses = '' ";
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


        /// <summary>
        /// Adds a visit
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public int AddVisit(Visit visit)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO visitRoutineResults " +
                "(appointmentID, nurseID, visitDatetime, height, weight, bloodPressureDiastolic, " +
                "bloodPressureSystolic, bodyTemperature, pulse, symptoms, initialDiagnoses, finalDiagnoses)" +
                "VALUES (@appointmentID, @nurseID, @visitDatetime, @height, @weight, " +
                "@bloodPressureDiastolic, @bloodPressureSystolic, @bodyTemperature, " +
                "@pulse, @symptoms, @initialDiagnoses, @finalDiagnoses)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@appointmentID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@appointmentID"].Value = visit.AppointmentID;

            insertCommand.Parameters.Add("@nurseID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@nurseID"].Value = visit.NurseID;

            insertCommand.Parameters.Add("@visitDatetime", System.Data.SqlDbType.DateTime);
            insertCommand.Parameters["@visitDatetime"].Value = visit.VisitDatetime;

            insertCommand.Parameters.Add("@height", System.Data.SqlDbType.Decimal);
            insertCommand.Parameters["@height"].Value = visit.Height;

            insertCommand.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
            insertCommand.Parameters["@weight"].Value = visit.Weight;

            insertCommand.Parameters.Add("@bloodPressureDiastolic", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@bloodPressureDiastolic"].Value = visit.BloodPressureDiastolic;

            insertCommand.Parameters.Add("@bloodPressureSystolic", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@bloodPressureSystolic"].Value = visit.BloodPressureSystolic;

            insertCommand.Parameters.Add("@bodyTemperature", System.Data.SqlDbType.Decimal);
            insertCommand.Parameters["@bodyTemperature"].Value = visit.BodyTemperature;

            insertCommand.Parameters.Add("@pulse", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@pulse"].Value = visit.Pulse;

            insertCommand.Parameters.Add("@symptoms", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@symptoms"].Value = visit.Symptoms;

            insertCommand.Parameters.Add("@initialDiagnoses", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@initialDiagnoses"].Value = visit.InitialDiagnoses;

            insertCommand.Parameters.Add("@finalDiagnoses", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@finalDiagnoses"].Value = visit.FinalDiagnoses;

            using (insertCommand)
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('visitRoutineResults') FROM visitRoutineResults";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                using (selectCommand)
                {
                    int visitID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return visitID;
                }
            }
        }

        /// <summary>
        /// Gets a list of visits based on appointment id
        /// </summary>
        /// <param name="appointmentIDIn"></param>
        /// <returns></returns>
        public List<Visit> GetVisitInformationListByAppointmentID(int appointmentIDIn)
        {
            List<Visit> visits = new List<Visit>();
            string selectStatement =
                " SELECT v.visitID, v.appointmentID " +
                " FROM appointment a, visitRoutineResults v " +
                " where v.appointmentID = @appointmentIDIn ";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appointmentIDIn", appointmentIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit();

                            visit.VisitID = (int)(reader)["VisitID"];
                            visit.AppointmentID = (int)(reader)["appointmentID"];
                            visits.Add(visit);
                        }
                    }
                }
            }
            return visits;
        }

        /// <summary>
        /// Returns the visit based on the visit id
        /// </summary>
        /// <param name="appointmentIDIn"></param>
        /// <returns></returns>
        public Visit GetVisitInformationByAppointmentID(int appointmentIDIn)
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
                "and v.appointmentID = @appointmentIDIn ";
            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appointmentIDIn", appointmentIDIn);

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
        /// Updates visit information before the final diagnosis is input
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public int UpdateVisit(Visit visit)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string updateStatement =
                "UPDATE visitRoutineResults " +
                "SET nurseID = @nurseID, visitDatetime = @visitDatetime, " +
                "height = @height, weight = @weight, bloodPressureDiastolic = @bloodPressureDiastolic, " +
                "bloodPressureSystolic = @bloodPressureSystolic, bodyTemperature = @bodyTemperature, " +
                "pulse = @pulse, symptoms = @symptoms, initialDiagnoses = @initialDiagnoses, " +
                "finalDiagnoses = @finalDiagnoses " +
                "WHERE appointmentID = @appointmentID ";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@appointmentID", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@appointmentID"].Value = visit.AppointmentID;

            updateCommand.Parameters.Add("@nurseID", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@nurseID"].Value = visit.NurseID;

            updateCommand.Parameters.Add("@visitDatetime", System.Data.SqlDbType.DateTime);
            updateCommand.Parameters["@visitDatetime"].Value = visit.VisitDatetime;

            updateCommand.Parameters.Add("@height", System.Data.SqlDbType.Decimal);
            updateCommand.Parameters["@height"].Value = visit.Height;

            updateCommand.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
            updateCommand.Parameters["@weight"].Value = visit.Weight;

            updateCommand.Parameters.Add("@bloodPressureDiastolic", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@bloodPressureDiastolic"].Value = visit.BloodPressureDiastolic;

            updateCommand.Parameters.Add("@bloodPressureSystolic", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@bloodPressureSystolic"].Value = visit.BloodPressureSystolic;

            updateCommand.Parameters.Add("@bodyTemperature", System.Data.SqlDbType.Decimal);
            updateCommand.Parameters["@bodyTemperature"].Value = visit.BodyTemperature;

            updateCommand.Parameters.Add("@pulse", System.Data.SqlDbType.Int);
            updateCommand.Parameters["@pulse"].Value = visit.Pulse;

            updateCommand.Parameters.Add("@symptoms", System.Data.SqlDbType.VarChar);
            updateCommand.Parameters["@symptoms"].Value = visit.Symptoms;

            updateCommand.Parameters.Add("@initialDiagnoses", System.Data.SqlDbType.VarChar);
            updateCommand.Parameters["@initialDiagnoses"].Value = visit.InitialDiagnoses;

            updateCommand.Parameters.Add("@finalDiagnoses", System.Data.SqlDbType.VarChar);
            updateCommand.Parameters["@finalDiagnoses"].Value = visit.FinalDiagnoses;

            using (updateCommand)
            {
                connection.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                return rowsAffected;
            }
        }
    }
}
