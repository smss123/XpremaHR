using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.SalaryProfileCommands
{
    class SalaryProfileCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Salary Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="S"></param>
        public static void NewSalaryProfile(SalaryProfile S)
        {
            db.SalaryProfiles.InsertOnSubmit(S);
            db.SubmitChanges();
            OnCommandChange("New Salary Profile ", S.EmployeeID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Salary Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="S"></param>
        public static void EditSalaryProfile(SalaryProfile S)
        {
            var q = db.SalaryProfiles.Where(p => p.ID == S.ID).SingleOrDefault();
            q.EmployeeID = S.EmployeeID;
            q.SalaryItemID = S.SalaryItemID;
            q.Amount = S.Amount;
            q._SerialNumber = S._SerialNumber;
            db.SubmitChanges();
            OnCommandChange("Edit Salary Profile  ", S.EmployeeID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Expensses  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteSalaryProfile(int id)
        {
            var q = db.SalaryProfiles.Where(p => p.ID == id).SingleOrDefault();
            db.SalaryProfiles.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Salary Profile ", q.EmployeeID + " has been Deleted");// fired Event on Form
        }
        public static List<SalaryProfile> GetAllSalaryProfile()
        {
            return db.SalaryProfiles.ToList();
        }
    }
}
