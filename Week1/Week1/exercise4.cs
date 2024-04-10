using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class exercise4
    {
        public static String ComparePrices(String[] usaArr, String[] europeArr)
        {
            bool equal = false;
            for (int i = 0; i < usaArr.Length; i++)
            {
                if (Decimal.Parse(usaArr[i]) * 1.8m == Decimal.Parse(europeArr[i]) * 1.95m)
                {
                    equal = true;
                }
            }

            if (equal)
            {
                return "Equal";
            }

            return "Not equal";
        }
    }
}
