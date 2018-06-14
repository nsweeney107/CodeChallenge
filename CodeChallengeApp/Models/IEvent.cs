using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeApp.Models
{
    interface IEvent
    {
        //string EventType { get; set; }
        //// Number for the smaller number of the two checks in the Event
        //int LowerNumber { get; set; }
        //// Text for the smaller number of the two checks in the Event
        //string LowerNumberText { get; set; }
        //// Number for the larger number of the two checks in the Event
        //int UpperNumber { get; set; }
        //// Text for the larger number of the two checks in the Event
        //string UpperNumberText { get; set; }
        //// Text for the combined text
        //string CombinedText { get; set; }

        event EventHandler<CodeChallengeEventArgs> EventFired;
        void OnEventFired(CodeChallengeEventArgs e);
        void FireEvent();
    }
}
