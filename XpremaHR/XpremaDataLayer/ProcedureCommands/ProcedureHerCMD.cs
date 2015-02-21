using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.ProcedureCommands
{
    class ProcedureHerCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Procedure Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="PH"></param>
        public static void NewProcedureHer(ProcedureHer PH)
        {
            db.ProcedureHers.InsertOnSubmit(PH);
            db.SubmitChanges();
            OnCommandChange("New Procedure Her ", PH.ProcedureID + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Procedure Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="PH""></param>
        public static void EditProcedureHer(ProcedureHer PH)
        {
            var q = db.ProcedureHers.Where(p => p.id == PH.id).SingleOrDefault();
            q.SortOfProcedure = PH.SortOfProcedure;
            q.description = PH.description;
            db.SubmitChanges();
            OnCommandChange("Edit Procedure Her", PH.ProcedureID + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Procedure Her  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteProcedureHer(int id)
        {
            var q = db.ProcedureHers.Where(p => p.id == id).SingleOrDefault();
            db.ProcedureHers.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Procedure Her", q.ProcedureID + " has been Deleted");// fired Event on Form
        }
        public static List<ProcedureHer> GetAllProcedureHer()
        {
            return db.ProcedureHers.ToList();
        }
    }
}
