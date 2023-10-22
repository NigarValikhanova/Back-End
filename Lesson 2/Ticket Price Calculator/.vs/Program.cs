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
            string dayofweek = Console.ReadLine();
            Console.WriteLine("All movies tickets are the same price. But our tickets may vary in price only in accordance with your age. So please enter your age");
            byte age = Convert.ToByte(Console.ReadLine());
            int senior = 7;
            int adult = 10;
            int child = 5;
            int ticketprice = 0;

            if (dayofweek == "Wednesday")
            {
                if (age >= 65)
                {
                    ticketprice = senior - 2;
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $" + ticketprice);
                }
                else if (age >= 13)
                {
                    ticketprice = adult - 2;
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $" + ticketprice);
                }
                else if (age >= 0)
                {
                    ticketprice = child - 2;
                    Console.WriteLine("We have $2 discount for you. Your ticket price is $" + ticketprice);
                }

            }
            else if (dayofweek != "Wednesday")
            {
                if (age >= 65)
                {
                    Console.WriteLine("Your ticket price is $" + senior);
                }         
                else if (age >= 13)
                {
                    Console.WriteLine("Your ticket price is $" + adult);
                }
                else if (age >= 0)
                {
                    Console.WriteLine("Your ticket price is $" + child);
                }
            }
            Console.WriteLine("Enjoy your movie");
            Console.ReadLine();
        }
    }
}