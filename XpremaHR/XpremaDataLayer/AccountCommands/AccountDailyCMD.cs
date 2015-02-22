using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.AccountCommands
{
    class AccountDailyCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;
        /// <summary>
        /// To Add New Account Daily  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="A]"></param>
        public static void NewAccountDaily(AccountDaily AD)
        {
            db.AccountDailies.InsertOnSubmit(AD);
            db.SubmitChanges();
            OnCommandChange("New Account Daily ", AD.Account.AccountName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Account  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="AD"></param>
        public static void EditAccountDaily(AccountDaily AD)
        {
            var q = db.AccountDailies.Where(p => p.ID == AD.ID).SingleOrDefault();

            q.TotalIn = AD.TotalIn;
            q.TotalOut = AD.TotalOut;
            q.DateOfProcess = AD.DateOfProcess;
            q.Description = AD.Description;
            q.CommandArg = AD.CommandArg;



            db.SubmitChanges();
            OnCommandChange("Edit Account Daily ", AD.Account.AccountName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Account  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteAccountDaily(int id)
        {
            var q = db.AccountDailies.Where(p => p.ID == id).SingleOrDefault();
            db.AccountDailies.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Account Daily ", q.Account.AccountName + " has been Deleted");// fired Event on Form
        }
        public static List<AccountDaily> GetAllAccountDaily()
        {
            return db.AccountDailies.ToList();
        }
    }
}
