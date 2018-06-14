using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeApp.Models
{
    public class CodeChallengeEventArgs : EventArgs
    {
        public enum EventTypeEnum { Register, Diagnose }

        public readonly string EventType;
        public readonly int LowerNumber;
        public readonly string LowerNumberText;
        public readonly int UpperNumber;
        public readonly string UpperNumberText;
        public readonly string CombinedText;

        public CodeChallengeEventArgs(EventTypeEnum eventType, int lowerNumber, string lowerNumberText, int upperNumber, string upperNumberText)
        {
            EventType = eventType.ToString();
            LowerNumber = lowerNumber;
            LowerNumberText = lowerNumberText;
            UpperNumber = upperNumber;
            UpperNumberText = upperNumberText;
            CombinedText = lowerNumberText + " " + upperNumberText;
        }
    }
}
