namespace Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 6;
            SwapInt(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            int[] arr = { 1, 2, 3, 4, 5 };
            int min, max;
            double average;
            CalculateNumericalStatistics(arr, out min, out max, out average);
            Console.WriteLine("Min:", min);
            Console.WriteLine("Max:", max);
            Console.WriteLine("Average:", average);

            int num = 6;
            bool even, odd;
            CheckOddOrEven(num, out even, out odd);
            Console.WriteLine("Number {0} is even {1}", num, odd);
            Console.WriteLine("Number {0} is odd {1}", num, odd);

            String language = "English", theme = "Dark", font = "Comic Sans";
            UpdateProfile(ref language, ref theme, ref font);
            Console.WriteLine(language, theme, font);

            int num4 = 4;
            long result;
            Factorial(num,out result);

            int num5 = 5;
            int swapnum = 10;
            FindAndSwapElement(ref arr, num5, swapnum);

            int[] oddArr, evenArr;
            Segmentation(ref arr, out oddArr, out evenArr);
        }

        public static void SwapInt(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static void CalculateNumericalStatistics(int[] numsArr, out int min, out int max, out double average)
        {
            int minValue = int.MaxValue, maxValue = int.MinValue, averageValue = 0;

            min = int.MaxValue;
            max = int.MinValue;
            int sum = 0;

            foreach (var number in numsArr)
            {
                if (number < minValue) minValue = number;
                if (number > maxValue) maxValue = number;
                sum += number;
            }

            average = (double)sum / numsArr.Length;
        }


        public static void CheckOddOrEven(int num, out bool even, out bool odd)
        {
            even = (num % 2 == 0);
            odd = (!even);

        }

        public static void UpdateProfile(ref String languange, ref String theme, ref String font)
        {
            String newLanguage = Console.ReadLine();
            String newTheme = Console.ReadLine();
            String newFont = Console.ReadLine();
        }

        public static void Factorial(int num, out long factorial) 
        {
            factorial = 1;
            for (int i = 1; i <= num; i++) 
            {
                factorial *= i;
            }

        }

        public static void FindAndSwapElement(ref int[] arr, int element, int swapElement)
        { 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element) 
                {
                    arr[i] = swapElement;    
                }
            }
        }

        public static void Segmentation(ref int[] arr, out int[] oddArr, out int[] evenArr)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach(var number in arr)
            {
                if(number % 2 == 0) evens.Add(number);
                else
                    odds.Add(number);
            }

            evenArr = evens.ToArray();
            oddArr = odds.ToArray();
        } 
    }
}