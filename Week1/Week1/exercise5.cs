using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class exercise5
    {
        public static String isLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return "Is leap year.";
            }

            return "Isn't leap year.";
        }
    }
}
