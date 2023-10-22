using System.Transactions;

namespace Task_03._08._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multiplication Table
            //Console.WriteLine("Please, enter a number");

            //int x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine(i * x);

            //}
            #endregion

            #region Array

            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            // maxNumber you can use this method also  ===  Console.WriteLine(numbers.Max());

            //int maxNumber = numbers[0]; //12

            //foreach (int item in numbers)
            //{
            //    if (item > maxNumber)
            //    {
            //        maxNumber = item;
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //minNumber you can also use this method ====  //Console.WriteLine(numbers.Min());
            //int minNumber = numbers[0];
            //foreach(int item in numbers)
            //{ 
            //    if (item < minNumber) 
            //    {
            //        minNumber = item;
            //    }
            //}
            //Console.WriteLine(minNumber);


            // sumNumber you can also use this method         //Console.WriteLine(numbers.Sum());
            int sumNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumNumber += numbers[i];
            }

            Console.WriteLine(sumNumber);

            // repeated numbers count
            int count = 0;
            foreach (var item in numbers)
            {
                if (item == 9)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " times the number 9 repeated");

            // numbers between 10-30

            foreach (var item in numbers)
            {
                if (item >= 10 && item <= 30)
                {
                    Console.WriteLine(item);
                }

            }
            #endregion

            #region Switch case calculator

            //Console.WriteLine("Enter a number, please");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number, please");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the symbol, please");
            //string symbol = Console.ReadLine();
            //int result = 0;
            //switch (symbol)
            //{
            //    case "+":
            //        result = num1 + num2;
            //        Console.WriteLine($"Your answer is  {result}");
            //        break;
            //    case "-":
            //        result = num1 - num2;
            //        Console.WriteLine($"Your answer is  {result}");
            //        break;
            //    case "*":
            //        result = num1 * num2;
            //        Console.WriteLine($"Your answer is  {result}");
            //        break;
            //    case "/":
            //        result = num1 / num2;
            //        Console.WriteLine($"Your answer is  {result}");
            //        break;
            //}
            //Console.ReadLine();
            #endregion

            #region Inventory of Books

            //string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            //string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            //string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            //int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };


            //for (int i = 0; i < bookTitles.Length; i++)
            //{
            //    Console.WriteLine($"Book Name: {bookTitles[i]}, Author: {bookAuthors[i]}, Genre: {bookGenres[i]}, Available Copies: {bookCopiesAvailable[i]}");
            //}

            #endregion

        }
    }

}
   