using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise2
    {
        static public String CheckPrime(int n)
        {
            String result = "Isn't prime";
            if (n > 1)
            {
                for (int i = 0; i<n; i++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 == 0)
                    {
                        result = "Is prime";
                    }
                }
            }
            return result;
        }
    }
}
