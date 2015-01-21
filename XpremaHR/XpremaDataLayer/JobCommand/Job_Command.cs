using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.JobCommand
{
    public class Job_Command:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Job  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="j"></param>
        public static void NewJob(Job j)
        {
            db.Jobs.InsertOnSubmit(j);
            db.SubmitChanges();
            OnCommandChange("New Job ", j.JobName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Job  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="j"></param>
        public static void EditJob(Job j)
        {
            var q = db.Jobs.Where(p => p.ID == j.ID).SingleOrDefault();
            q.JobName = j.JobName;
            q.JobDescription = j.JobDescription;
            q.GroupID = j.GroupID;
            db.SubmitChanges();
            OnCommandChange("Edit Job Group", j.JobName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Job Group , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteJob(int id)
        {
            var q = db.Jobs.Where(p => p.ID == id).SingleOrDefault();
            db.Jobs.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Job Group", q.JobName + " has been Deleted");// fired Event on Form
        }
        public static List<Job> GetAllJobGroups()
        {
            return db.Jobs.ToList();
        }
    }
}
