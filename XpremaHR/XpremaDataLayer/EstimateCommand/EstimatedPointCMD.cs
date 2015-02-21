using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.EstimateCommand
{

    class EstimatedPointCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Estimated Point  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E"></param>
        public static void NewEstimatedPoint(EstimatedPoint E)
        {
            db.EstimatedPoints.InsertOnSubmit(E);
            db.SubmitChanges();
            OnCommandChange("New Estimated Point ", E.EstimatedName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Estimated Point  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="E""></param>
        public static void EditEstimatedPoint(EstimatedPoint E)
        {
            var q = db.EstimatedPoints.Where(p => p.ID == E.ID).SingleOrDefault();
            q.EstimatedName = E.EstimatedName;
            q.point = E.point;
            db.SubmitChanges();
            OnCommandChange("Edit Estimated Pointe", E.EstimatedName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to Estimated Point  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteEstimatedPoint(int id)
        {
            var q = db.EstimatedPoints.Where(p => p.ID == id).SingleOrDefault();
            db.EstimatedPoints.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Estimated Point", q.EstimatedName + " has been Deleted");// fired Event on Form
        }
        public static List<EstimatedPoint> GetAllEstimatedPoint()
        {
            return db.EstimatedPoints.ToList();
        }
    }
}
