using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.UserCommands
{
   public class UserCMD : SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New UserINFO  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="U"></param>
        public static void NewUser(User u)
        {
            db.Users.InsertOnSubmit(u);
            db.SubmitChanges();
            OnCommandChange("New User ", u.UserName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit UserINFO  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="U"></param>
        public static void EditUser(User u)
        {
            var q = db.Users.Where(p => p.ID == u.ID).SingleOrDefault();
            q.UserName = u.UserName;
            q.Password = u.Password;
            q.GroupID = u.GroupID;
            q.EmployeeID = u.EmployeeID;
            db.SubmitChanges();
            OnCommandChange("Edit User Info", u.UserName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete User  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteUser(int id)
        {
            var q = db.Users.Where(p => p.ID == id).SingleOrDefault();
            db.Users.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Job Group", q.UserName + " has been Deleted");// fired Event on Form
        }
        public static List<User> GetAllUserGroups()
        {
            return db.Users.ToList();
        }
    }
}
