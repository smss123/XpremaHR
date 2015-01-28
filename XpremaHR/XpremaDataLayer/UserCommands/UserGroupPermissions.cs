using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.UserCommands
{
    class UserGroupPermissions:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New User Group permssion  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="gp"></param>
        public static void NewUserGroup(GroupPermession gp)
        {
            db.GroupPermessions.InsertOnSubmit(gp);
            db.SubmitChanges();
            OnCommandChange("New Group Permssion ", gp.PermessionID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit group permssion  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="gp"></param>
        public static void EditUserGrouppermsion(GroupPermession gp)
        {
            var q = db.GroupPermessions.Where(p => p.ID == gp.ID).SingleOrDefault();
            q.GroupID = gp.GroupID;
            q.PermessionID = gp.PermessionID;
            q.AlternateValue = gp.AlternateValue;
            q.ValueX = gp.ValueX;
            db.SubmitChanges();
            OnCommandChange("Edit Job Group", gp.PermessionID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete User Group permssion , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteUserGrouppermssion(int id)
        {
            var q = db.GroupPermessions.Where(p => p.ID == id).SingleOrDefault();
            db.GroupPermessions.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Job Group", q.PermessionID + " has been Deleted");// fired Event on Form
        }
        public static List<GroupPermession> GetAllUserGrouppermssion()
        {
            return db.GroupPermessions.ToList();
        }
    }
}
