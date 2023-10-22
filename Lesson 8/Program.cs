using System.Text;

namespace _21._08._2023_task
{
    internal class Program

    {
        static void Main(string[] args)
        {
            #region Task
            //IsOdd
            //ExtentionMethods.IsOdd(25);

            //IsEven
            //ExtentionMethods.IsEven(48);

            //IsContainsDigit

            string text1 = "Nigar1109";
            Console.WriteLine(ExtentionMethods.IsContainsDigit(text1));

            //

            //string text = "bolshit tsirt";

            //string searchingtext = "shit";
            //int[] indexes = text.GetValueIndexes(searchingtext);

            //if (indexes.Length == 0)
            //{
            //    Console.WriteLine("Nothing found");
            //}
            //else
            //{
            //    Console.WriteLine($"{searchingtext} found");
            //}
            #endregion

        }
    }
    static class ExtentionMethods
    {
        public static bool IsOdd(int numbers)
        {
            bool IsOdd = false;
            if (numbers % 2 == 1)
            {
                IsOdd = true;
                Console.WriteLine("It is an odd number");
            }
            else
            {
                IsOdd = false;
                Console.WriteLine("It is not an odd number");
            }
            return IsOdd;
        }
        public static bool IsEven(int numbers)
        {
            bool IsEven = false;
            if (numbers % 2 == 0)
            {
                IsEven = true;
                Console.WriteLine("It is an even number");
            }
            else
            {
                IsEven = false;
                Console.WriteLine("It is not an even number");
            }
            return IsEven;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

    }


}