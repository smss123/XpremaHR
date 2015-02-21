using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.EmployeeCommand
{
    class EmployeeBasicInfoCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New EMPINFO  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewEMP(EmployeeBasicInfo E)
        {
            db.EmployeeBasicInfos.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New Employee ", E.EmpName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit EMPINFO  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void EditEMP(EmployeeBasicInfo E)
        {
            var q = db.EmployeeBasicInfos.Where(p => p.SerialNumber == E.SerialNumber).SingleOrDefault();
            q.EmpName = E.EmpName;
            q.Address = E.Address;
            q.MobileNo = E.MobileNo;
            q.Email = E.Email;
            q.BloodGroup = E.BloodGroup;
            q.Nationalty = E.Nationalty;
            q.nationaltyID = E.nationaltyID;
            q.status = E.status;
            q.JobID = E.JobID;
            q.CreateDate = E.CreateDate;
            q.HereDate = E.HereDate;
            db.SubmitChanges();
            OnCommandChange("Edit Employee Info", E.EmpName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete EMP  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteEmployee(int id)
        {
            var q = db.EmployeeBasicInfos.Where(p => p.SerialNumber == id).SingleOrDefault();
            db.EmployeeBasicInfos.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Employee Info", q.EmpNumber + " has been Deleted");// fired Event on Form
        }
        public static List<EmployeeBasicInfo> GetAllemployee()
        {
            return db.EmployeeBasicInfos.ToList();
        }
    }
}
