using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.UserCommands
{
    public class UserGroupCommand:SystemBase
    {

            public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New User Group  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="g"></param>
        public static void NewUserGroup(UserGroup g)
        {
            db.UserGroups.InsertOnSubmit(g);
            db.SubmitChanges();
            OnCommandChange("New Job ", g.GroupName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Job  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="g"></param>
        public static void EditUserGroup(UserGroup g)
        {
            var q = db.UserGroups.Where(p => p.ID == g.ID).SingleOrDefault();
            q.GroupName = g.GroupName;
            q.GroupDescription = g.GroupDescription;
            db.SubmitChanges();
            OnCommandChange("Edit Job Group", g.GroupName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete User Group , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteUserGroup(int id)
        {
            var q = db.UserGroups.Where(p => p.ID == id).SingleOrDefault();
            db.UserGroups.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Job Group", q.GroupName + " has been Deleted");// fired Event on Form
        }
        public static List<UserGroup> GetAllUserGroups()
        {
            return db.UserGroups.ToList();
        }
    }
    }
}
