using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.UserCommands
{
    class UserPermissionCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add User Permession , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="UP"></param>
        public static void NewSystemPermession(UserPermession UP)
        {
            db.UserPermessions.InsertOnSubmit(UP);
            db.SubmitChanges();
            OnCommandChange("New System Permession ", UP.SystemUserID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit User Permession  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="UP"></param>
        public static void EditSystemPermession(UserPermession UP)
        {
            var q = db.UserPermessions.Where(p => p.ID == UP.ID).SingleOrDefault();

            q.SystemUserID = UP.SystemUserID;
            q.PermessionValue = UP.PermessionValue;
            q.SystemPermessionID = UP.SystemPermessionID;
            q.SerialNumber = UP.SerialNumber;


            db.SubmitChanges();
            OnCommandChange("Edit System Permession", UP.SystemUserID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete User Permession , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteUserPermession(int id)
        {
            var q = db.UserPermessions.Where(p => p.ID == id).SingleOrDefault();
            db.UserPermessions.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete System Permession", q.SystemUserID + " has been Deleted");// fired Event on Form
        }
        public static List<UserPermession> GetAllUserPermessions()
        {
            return db.UserPermessions.ToList();
        }
    }
}
