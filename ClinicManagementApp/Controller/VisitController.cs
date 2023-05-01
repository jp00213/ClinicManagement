using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the VisitController and the View.
    /// </summary>
    public class VisitController
    {
        private readonly VisitDAL _visitDAL;

        /// <summary>
        /// Create a VisitController object.
        /// </summary>
        public VisitController()
        {
            this._visitDAL = new VisitDAL();
        }

        /// <summary>
        /// Get visit information list by PatientID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>visit information list</returns>
        public List<Visit> GetVisitInformationListByPatientID(int patientIDIn)
        {
            return this._visitDAL.GetVisitInformationListByPatientID(patientIDIn);
        }

        /// <summary>
        /// Get visit information list by VisitID
        /// </summary>
        /// <param name="visitIDIn">visit ID</param>
        /// <returns>visit information</returns>
        public Visit GetVisitInformationByVisitID(int visitIDIn)
        {
            return this._visitDAL.GetVisitInformationByVisitID(visitIDIn);
        }

        /// <summary>
        /// Enter final diagnosis
        /// </summary>
        /// <param name="visitDataIn">visit data</param>
        /// <returns>if final diagnosis is entered</returns>
        public bool EnterFinalDiagnosis(Visit visitDataIn)
        {
            return this._visitDAL.EnterFinalDiagnosis(visitDataIn);
        }

        /// <summary>
        /// Adds a visit
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public int AddVisit(Visit visit)
        {
            return this._visitDAL.AddVisit(visit);
        }

        /// <summary>
        /// Gets the visit info based on appointment id
        /// </summary>
        /// <param name="appointmentIDIn"></param>
        /// <returns></returns>
        public List<Visit> GetVisitInformationListByAppointmentID(int appointmentIDIn)
        {
            return this._visitDAL.GetVisitInformationListByAppointmentID(appointmentIDIn);
        }

        /// <summary>
        /// Gets the visit infomation based on the appointment ID
        /// </summary>
        /// <param name="appointmentIDIn"></param>
        /// <returns></returns>
        public Visit GetVisitInformationByAppointmentID(int appointmentIDIn)
        {
            return this._visitDAL.GetVisitInformationByAppointmentID(appointmentIDIn);
        }

        /// <summary>
        /// Updates the visit information
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public int UpdateVisit(Visit visit)
        {
            return this._visitDAL.UpdateVisit(visit);
        }
    }
}
