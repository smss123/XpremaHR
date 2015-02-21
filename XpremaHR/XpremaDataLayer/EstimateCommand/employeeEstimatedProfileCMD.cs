using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.EstimateCommand
{
    class employeeEstimatedProfileCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New employee Estimated Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewProcedureHer(employeeEstimatedProfile E)
        {
            db.employeeEstimatedProfiles.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New employee Estimated Profile ", E.employeeID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit employee Estimated Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E""></param>
        public static void EditemployeeEstimatedProfile(employeeEstimatedProfile E)
        {
            var q = db.employeeEstimatedProfiles.Where(p => p.id == E.id).SingleOrDefault();
            q.estimatedpoint = E.estimatedpoint;
            db.SubmitChanges();
            OnCommandChange("Edit employee Estimated Profile", E.employeeID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to employee Estimated Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteemployeeEstimatedProfile(int id)
        {
            var q = db.employeeEstimatedProfiles.Where(p => p.id == id).SingleOrDefault();
            db.employeeEstimatedProfiles.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete employee Estimated Profile", q.employeeID + " has been Deleted");// fired Event on Form
        }
        public static List<employeeEstimatedProfile> GetAllemployeeEstimatedProfile()
        {
            return db.employeeEstimatedProfiles.ToList();
        }
    }
}
