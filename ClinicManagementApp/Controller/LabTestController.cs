using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the LabTestDAL and the View.
    /// </summary>
    public class LabTestController
    {
        private readonly LabTestDAL _labTestDAL;

        /// <summary>
        /// Create a LabTestController object.
        /// </summary>
        public LabTestController() 
        {
            this._labTestDAL = new LabTestDAL();
        }

        /// <summary>
        /// Get labTest list by visit ID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>lab test list</returns>
        public List<LabTest> GetLabTestListByVisitID(int patientIDIn)
        {
            return this._labTestDAL.GetLabTestListByVisitID(patientIDIn);
        }


        public List<LabTest> GetLabTests()
        {
            return this._labTestDAL.GetLabTests();
        }

        /// <summary>
        /// Update lab test details
        /// </summary>
        /// <returns>success message</returns>
        /// <param name="test"> test object to be updated</param>
        public bool UpdateLabTest(LabTest test) => _labTestDAL.UpdateLabTest(test);

    }
}
