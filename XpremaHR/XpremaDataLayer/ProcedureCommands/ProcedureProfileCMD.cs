using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer.ProcedureCommands
{
    class ProcedureProfileCMD:SystemBase
    {
        public static event OnCommandChangeCallBack OnCommandChange;

        /// <summary>
        /// To Add New Procedure Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="P"></param>
        public static void NewProcedureProfile(ProcedureProfile P)
        {
            db.ProcedureProfiles.InsertOnSubmit(P);
            db.SubmitChanges();
            OnCommandChange("New Procedure Profile ", P.procedureName + " has been Saved");// fired Event on Form
        }
        /// <summary>
        /// To Edit Procedure Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="PR"></param>
        public static void EditProcedureProfile(ProcedureProfile PR)
        {
            var q = db.ProcedureProfiles.Where(p => p.id == PR.id).SingleOrDefault();
            q.procedureName = PR.procedureName;
            q.Description = PR.Description;
            db.SubmitChanges();
            OnCommandChange("Edit Procedure Profile", PR.procedureName + " has been Edited");// fired Event on Form
        }

        /// <summary>
        /// to delete Procedure Profile  , in any error here to save to excption handler wel be fired
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteProcedureProfile(int id)
        {
            var q = db.ProcedureProfiles.Where(p => p.id == id).SingleOrDefault();
            db.ProcedureProfiles.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnCommandChange("Delete Procedure Profile", q.procedureName + " has been Deleted");// fired Event on Form
        }
        public static List<ProcedureProfile> GetAllProcedureProfile()
        {
            return db.ProcedureProfiles.ToList();
        }
    }
}
