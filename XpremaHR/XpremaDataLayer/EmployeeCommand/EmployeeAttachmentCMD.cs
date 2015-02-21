using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.EmployeeCommand
{
    class EmployeeAttachmentCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Employee Attachment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewEmployeeAttachment(EmployeeAttachment E)
        {
            db.EmployeeAttachments.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New Employee Attachment ", E.EmployeeBasicInfo.EmpName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Employee Attachment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void EditEmployeeAttachment(EmployeeAttachment E)
        {
            var q = db.EmployeeAttachments.Where(p => p.ID == E.ID).SingleOrDefault();

            q.EmployeeID = E.EmployeeID;
            q.Attachment = E.Attachment;
            q.AttachmentDesription = E.AttachmentDesription;
            db.SubmitChanges();
            OnCommandChange("Edit Employee Attachment", E.EmployeeBasicInfo.EmpName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Employee Attachment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteEmployeeAttachment(int id)
        {
            var q = db.EmployeeAttachments.Where(p => p.ID == id).SingleOrDefault();
            db.EmployeeAttachments.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Employee Attachment", q.EmployeeBasicInfo.EmpName + " has been Deleted");// fired Event on Form
        }
        public static List<EmployeeAttachment> GetAllEmployeeAttachment()
        {
            return db.EmployeeAttachments.ToList();
        }
    }
}
