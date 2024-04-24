using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(", ");

            //decimal result = class3.CalculatePricesSum(input);

            //string[] europeInput = Console.ReadLine().Split(", ");
            //string[] usaInput = Console.ReadLine().Split(", ");
            //String comparison = exercise4.ComparePrices(usaInput, europeInput);

            //Console.WriteLine(comparison);

            int year = int.Parse(Console.ReadLine());
            //Console.WriteLine(exercise5.isLeapYear(year));
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine(exercise6.isLeapYear(year) ? "29" : "28");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
            }
        }
    }
}