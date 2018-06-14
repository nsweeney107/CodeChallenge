using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeApp.Models
{
    class RegisterEvent : IEvent //Event
    {
        //public RegisterEvent() : base(EventTypeEnum.Register, 3, "Register", 5, "Patient")
        //{

        //}

        public void FireEvent()
        {
            OnEventFired(new CodeChallengeEventArgs(CodeChallengeApp.Models.CodeChallengeEventArgs.EventTypeEnum.Register, 3, "Register", 5, "Patient"));
        }
        public event EventHandler<CodeChallengeEventArgs> EventFired;

        public void OnEventFired(CodeChallengeEventArgs e)
        {
            if (EventFired != null) EventFired(this, e);
        }
    }
}
