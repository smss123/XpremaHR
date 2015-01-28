using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.CountryCommands
{
    class CountryCommands:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Country , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="C"></param>
        public static void NewCountry(Country C)
        {
            db.Countries.InsertOnSubmit(C);
            db.SubmitChanges();
            OnCommandChange("New Country ", C.CountryName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Country  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="C"></param>
        public static void EditCountry(Country C)
        {
            var q = db.Countries.Where(p => p.ID == C.ID).SingleOrDefault();
            q.CountryName = C.CountryName;
            q.description = C.description;
            q.SerialNumber = C.SerialNumber;
            db.SubmitChanges();
            OnCommandChange("Edit  Country", C.CountryName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Country , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteCountry(int id)
        {
            var q = db.Countries.Where(p => p.ID == id).SingleOrDefault();
            db.Countries.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Country", q.CountryName + " has been Deleted");// fired Event on Form
        }
        public static List<Country> GetAllCountry()
        {
            return db.Countries.ToList();
        }
    }
}
