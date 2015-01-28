using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.AccountCommands
{
    class AccountCommand:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Account  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="A"></param>
        public static void NewAccount(Account A)
        {
            db.Accounts.InsertOnSubmit(A);
            db.SubmitChanges();
            OnCommandChange("New Account ", A.AccountName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Account  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="A"></param>
        public static void EditAccount(Account A)
        {
            var q = db.Accounts.Where(p => p.ID == A.ID).SingleOrDefault();
            q.AccountName = A.AccountName;
            q.Description = A.Description;
            q.CategoryID = A.CategoryID;
            db.SubmitChanges();
            OnCommandChange("Edit Account ", A.AccountName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Account  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteAccount(int id)
        {
            var q = db.Accounts.Where(p => p.ID == id).SingleOrDefault();
            db.Accounts.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Accounts ", q.AccountName + " has been Deleted");// fired Event on Form
        }
        public static List<Account> GetAllAccount()
        {
            return db.Accounts.ToList();
        }
    }
}
