using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.SalaryItemCommands
{
    class SalaryItemCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
      /// To Add New Salary Item , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="SI"></param>
        public static void NewSalaryItem(SalaryItem SI)
        {
            db.SalaryItems.InsertOnSubmit(SI);
            db.SubmitChanges();
            OnCommandChange("New Salary Item ", SI.SalaryItem1 + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Salary Item  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="SI"></param>
        public static void EditSalaryItem(SalaryItem SI)
        {
            var q = db.SalaryItems.Where(p => p.ID == SI.ID).SingleOrDefault();
            q.SalaryItem1 = SI.SalaryItem1;
            q.SalaryItemDescription = SI.SalaryItemDescription;
            q.SelaryDirection = SI.SelaryDirection;
            q._SerialNumber = SI._SerialNumber;
            db.SubmitChanges();
            OnCommandChange("Edit Salary Item  ", SI.SalaryItem1 + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Salary Item  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteSalaryItem(int id)
        {
            var q = db.SalaryItems.Where(p => p.ID == id).SingleOrDefault();
            db.SalaryItems.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Salary Item ", q.SalaryItem1 + " has been Deleted");// fired Event on Form
        }
        public static List<SalaryItem> GetAllSalaryItem()
        {
            return db.SalaryItems.ToList();
        }
    }
}
