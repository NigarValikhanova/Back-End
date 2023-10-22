using System.Diagnostics;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'Watch Anything You Want With US' movie theater.");
            Console.WriteLine("If you want a ticket first you should decide which day you want to watch. Because we have a great discount on every Wednesday.");
            Console.WriteLine("So first, please, enter the weekday you want to watch");
            string weekday = Convert.ToString(Console.ReadLine());
            Console.WriteLine("All movies tickets are the same price. But our tickets may vary in price only in accordance with your age. So please enter your age");
            var age = Convert.ToInt32(Console.ReadLine());
            if (weekday == "Wednesday")
            {
                if (age >= 65)
                {
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $5");
                }
                else if (age >= 13)
                {
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $8");
                }
                else if (age >= 0)
                {
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $3");
                }

            }
            else if (weekday != "Wednesday")
            {
                if (age >= 65)
                {
                    Console.WriteLine("Your ticket price is $7");
                }         
                else if (age >= 13)
                {
                    Console.WriteLine("Your ticket price is $10");
                }
                else if (age >= 0)
                {
                    Console.WriteLine("Your ticket price is $5");
                }
            }
            Console.WriteLine.("Enjoy your movie");
            Console.ReadLine();
        }
    }
}