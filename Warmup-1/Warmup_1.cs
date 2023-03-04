using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingbat
{
    internal class Warmup_1
    {
        public static bool sleepIn(bool weekday, bool vacation)
        {
            return !weekday || vacation;
        }
        public static bool monkeyTrouble(bool aSmile, bool bSmile)
        {
            return aSmile && bSmile || !aSmile && !bSmile;
        }
    }
}