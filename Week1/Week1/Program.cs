using System.Security.Cryptography.X509Certificates;

namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] prices = new float[3];
            for (int i = 0; i<prices.Length; i++)
            {
                Console.WriteLine("Please enter a price: ");
                var n = float.Parse(Console.ReadLine());
            }
            float result = class3.CalculatePricesSum(prices);
            Console.WriteLine(result);
        }
    }
}