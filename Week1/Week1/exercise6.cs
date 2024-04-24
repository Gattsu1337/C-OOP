using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class exercise6
    {
        public static bool isLeapYear(int year)
        {
            bool isLeap = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? true : false;
            return isLeap;
        }
    }
}
