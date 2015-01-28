using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.ExpenssCommands
{
    class ExpenssCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Expenss  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewExpenss(Expenss E)
        {
            db.Expensses.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New Expensses ", E.ExpenssesName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Expenss  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name=E"></param>
        public static void EditExpenss(Expenss E)
        {
            var q = db.Expensses.Where(p => p.ID == E.ID).SingleOrDefault();
            q.ExpenssesName= E.ExpenssesName;
            q.Description = E.Description;
            q.AccountID = E.AccountID;
            db.SubmitChanges();
            OnCommandChange("Edit Expensses  ", E.ExpenssesName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Expensses  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteExpensses(int id)
        {
            var q = db.Expensses.Where(p => p.ID == id).SingleOrDefault();
            db.Expensses.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Expensses ", q.ExpenssesName + " has been Deleted");// fired Event on Form
        }
        public static List<Expenss> GetAllExpenss()
        {
            return db.Expensses.ToList();
        }
    }
}
