using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.AccountCommands
{
    class AccountCategoryCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Account Category  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="AC"></param>
        public static void NewAccountCategory(AccountCategory AC)
        {
            db.AccountCategories.InsertOnSubmit(AC);
            db.SubmitChanges();
            OnCommandChange("New Account Category ", AC.AccountCategoryName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Account Category  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="AC"></param>
        public static void EditAccountCategory(AccountCategory AC)
        {
            var q = db.AccountCategories.Where(p => p.ID == AC.ID).SingleOrDefault();
            q.AccountCategoryName = AC.AccountCategoryName;
            q.Description = AC.Description;
           
            db.SubmitChanges();
            OnCommandChange("Edit Account Category  ", AC.AccountCategoryName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Account Category   , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteAccountCategory (int id)
        {
            var q = db.AccountCategories.Where(p => p.ID == id).SingleOrDefault();
            db.AccountCategories.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Accounts ", q.AccountCategoryName + " has been Deleted");// fired Event on Form
        }
        public static List<AccountCategory> GetAllAccount()
        {
            return db.AccountCategories.ToList();
        }
    }
}
