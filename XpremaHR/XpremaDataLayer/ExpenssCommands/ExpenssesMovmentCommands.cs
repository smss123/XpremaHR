using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.ExpenssCommands
{
    class ExpenssesMovmentCommands:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Expensses Movment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="EM"></param>
        public static void NewExpenssesMovment(ExpenssesMovment EM)
        {
            db.ExpenssesMovments.InsertOnSubmit(EM);
            db.SubmitChanges();
            OnCommandChange("New Expensses ", EM.ExpenssesID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Expensses Movment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name=EM"></param>
        public static void EditExpenssesMovment(ExpenssesMovment EM)
        {
            var q = db.ExpenssesMovments.Where(p => p.ID == EM.ID).SingleOrDefault();
            q.ExpenssesID = EM.ExpenssesID;
            q.Amount = EM.Amount;
            q.DateOfProcess = EM.DateOfProcess;
            q.Description = EM.Description;
            db.SubmitChanges();
            OnCommandChange("Edit Expensses Movment  ", EM.ExpenssesID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Expensses Movment  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteExpenssesMovment(int id)
        {
            var q = db.ExpenssesMovments.Where(p => p.ID == id).SingleOrDefault();
            db.ExpenssesMovments.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Expensses Movment ", q.ExpenssesID + " has been Deleted");// fired Event on Form
        }
        public static List<ExpenssesMovment> GetAllExpenssesMovment()
        {
            return db.ExpenssesMovments.ToList();
        }
    }
}
