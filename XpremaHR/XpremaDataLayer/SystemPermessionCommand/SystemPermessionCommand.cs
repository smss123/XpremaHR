using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.SystemPermessionCommand
{
    class SystemPermessionCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add System Permession , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="CP"></param>
        public static void NewSystemPermession(SystemPermession CP)
        {
            db.SystemPermessions.InsertOnSubmit(CP);
            db.SubmitChanges();
            OnCommandChange("New System Permession ", CP.SystemPermession1 + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit System Permession  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="CP"></param>
        public static void EditSystemPermession(SystemPermession CP)
        {
            var q = db.SystemPermessions.Where(p => p.ID == CP.ID).SingleOrDefault();

            q.SystemPermession1 = CP.SystemPermession1;
            q.ObjectName = CP.ObjectName;
            q.propertyName = CP.propertyName;
            q.Description = CP.Description;
            q.SerialNumber = CP.SerialNumber;

            db.SubmitChanges();
            OnCommandChange("Edit System Permession", CP.SystemPermession1 + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete System Permession , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteSystemPermession(int id)
        {
            var q = db.SystemPermessions.Where(p => p.ID == id).SingleOrDefault();
            db.SystemPermessions.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete System Permession", q.SystemPermession1 + " has been Deleted");// fired Event on Form
        }
        public static List<SystemPermession> GetAllSystemPermessions()
        {
            return db.SystemPermessions.ToList();
        }
    }
}
