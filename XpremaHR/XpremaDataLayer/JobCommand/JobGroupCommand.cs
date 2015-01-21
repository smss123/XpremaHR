using System;
using System.Collections.Generic;
using System.Linq;

namespace XpremaDataLayer.JobCommand
{
    public class JobGroupCommand : SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Job Group , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="j"></param>
        public static void NewJobGroup(JobGroup j)
        {
            db.JobGroups.InsertOnSubmit(j);
            db.SubmitChanges();
            OnCommandChange("New Job Group",j.JobGroupName+" has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Job Group , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="j"></param>
        public static void EditJobGroup(JobGroup j)
        {
            var q = db.JobGroups.Where(p => p.ID == j.ID).SingleOrDefault();
            q.JobGroupName = j.JobGroupName;
            q.JobGroupDescription = j.JobGroupDescription;
            db.SubmitChanges();
            OnCommandChange("Edit Job Group", j.JobGroupName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Job Group , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteJobGroup(int id)
        {
            var q = db.JobGroups.Where(p => p.ID == id).SingleOrDefault();
            db.JobGroups.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Job Group", q.JobGroupName + " has been Deleted");// fired Event on Form
        }
        public static List<JobGroup> GetAllJobGroups()
        {
            return db.JobGroups.ToList();
        }
    }
}