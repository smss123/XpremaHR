using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.EmployeeCommand
{
    class employeeFamaliyCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New employee Famaliy  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewemployeeFamaliy(employeeFamaliy E)
        {
            db.employeeFamaliys.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New Employee ", E.Name + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit EMPINFO  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void EditEMPfamaliy(employeeFamaliy E)
        {
            var q = db.employeeFamaliys.Where(p => p.EmpID == E.EmpID).SingleOrDefault();

            q.Name = E.Name;
            q.Gender = E.Gender;
            q.Relationship = E.Relationship;
            q.Age = E.Age;
            q.ContactPhoneNumber = E.ContactPhoneNumber;
            db.SubmitChanges();
            OnCommandChange("Edit Employee Family Info", E.Name + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete EMP family enfo  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteEmployeefamilyinfo(int id)
        {
            var q = db.employeeFamaliys.Where(p => p.ID == id).SingleOrDefault();
            db.employeeFamaliys.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Employee family Info", q.Name + " has been Deleted");// fired Event on Form
        }
        public static List<employeeFamaliy> GetAllemployeefamily()
        {
            return db.employeeFamaliys.ToList();
        }
    }
}
