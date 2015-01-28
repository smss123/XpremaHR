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
            OnCommandChange("New System Permession ", CP.PermessionName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit System Permession  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="CP"></param>
        public static void EditSystemPermession(SystemPermession CP)
        {
            var q = db.SystemPermessions.Where(p => p.ID == CP.ID).SingleOrDefault();
            q.PermessionName = CP.PermessionName;
            q.PermessionDescription = CP.PermessionDescription;
            q.PermessionType = CP.PermessionType;
            db.SubmitChanges();
            OnCommandChange("Edit System Permession", CP.PermessionName + " has been Edited");// fired Event on Form
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
            OnCommandChange("Delete System Permession", q.PermessionName + " has been Deleted");// fired Event on Form
        }
        public static List<SystemPermession> GetAllSystemPermessions()
        {
            return db.SystemPermessions.ToList();
        }
    }
}
