using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeApp.Models
{
    class DiagnoseEvent : IEvent
    {
        //public DiagnoseEvent() : base(EventTypeEnum.Diagnose, 2, "Diagnose", 7, "Patient")
        //{ 
        //}

        public void FireEvent()
        {
            OnEventFired(new CodeChallengeEventArgs(CodeChallengeApp.Models.CodeChallengeEventArgs.EventTypeEnum.Diagnose, 2, "Diagnose", 7, "Patient"));
        }
        public event EventHandler<CodeChallengeEventArgs> EventFired;

        public void OnEventFired(CodeChallengeEventArgs e)
        {
            if (EventFired != null) EventFired(this, e);
        }
    }
}
