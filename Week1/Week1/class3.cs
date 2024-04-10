using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class class3
    {
        public static decimal CalculatePricesSum(String[] prices)
        {
            decimal pricesSum = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                pricesSum += Decimal.Parse(prices[i]);
            }

            return pricesSum;


    }
    }
}
