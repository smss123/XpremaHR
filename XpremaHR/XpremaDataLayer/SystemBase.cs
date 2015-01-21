using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpremaDataLayer
{
    public class SystemBase
    {
        public void Dispose()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public delegate void OnCommandChangeCallBack(string processType, string msg);

        public delegate void DbOnConnectionChangedCallBack(string status);

        public static event DbOnConnectionChangedCallBack DbOnConnectionChanged;
        protected static dbDataContext db = new dbDataContext();

        protected static void Initlization()
        {
            db = new dbDataContext();
            db.Connection.StateChange += Connection_StateChange;
        }

        static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            DbOnConnectionChanged(e.CurrentState.ToString());
        }

    }
}
