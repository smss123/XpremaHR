using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.CountryCommands
{
    class CityCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New City  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="C"></param>
        public static void NewEstimatedPoint(City C)
        {
            db.Cities.InsertOnSubmit(C);
            db.SubmitChanges();
            OnCommandChange("New Estimated Point ", C.cityName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Estimated Point  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E""></param>
        public static void EditCity(City C)
        {
            var q = db.Cities.Where(p => p.id == C.id).SingleOrDefault();
            q.cityName = C.cityName;
            q.description = C.description;
            db.SubmitChanges();
            OnCommandChange("Edit Estimated Point", C.cityName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to Delete city  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void Deletecity(int id)
        {
            var q = db.Cities.Where(p => p.id == id).SingleOrDefault();
            db.Cities.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete City ", q.cityName + " has been Deleted");// fired Event on Form
        }
        public static List<City> GetAllCities()
        {
            return db.Cities.ToList();
        }
    }
}
