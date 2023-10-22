using System.Collections;
using System.Reflection;

namespace Task10._08._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList booksList = new ArrayList() {"Pride and Prejudice", "In search of Lost Time", "Ulysses"};
            ArrayList authors = new ArrayList() { "Jane Austen", "Marcel Proust", "James Joyce"};
            ArrayList price = new ArrayList() { 75.20, 46.80, 125.30 };
            ArrayList quantities = new ArrayList();

            Console.WriteLine("Select an option\n" +
                "1. Add a new book\n" +
                "2. Remove a book\n" +
                "3. Update quantity\n" +
                "4. Calculate total value\n" +
                "5. Show all books\n" +
                "6. Exit");
            int j = 0;
            while (j < 6)
            {
                Console.Write("Select: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("How many books you want to add?");
                        int count =Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            AddBook(booksList, authors, price);
                        }
                        
                        break;
                    case 2:
                        RemoveBook(booksList);

                        break;
                    case 3:
                        Console.WriteLine("Sorry, I can`t update quantities of books");
                        break;
                    case 4:
                        CalcTotalValue(price); 
                        break;
                    case 5:
                        foreach (string item in booksList)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 6:
                        j = 6;
                        Console.WriteLine("Exited");
                        break;
                    default:
                        Console.WriteLine("There is no such an option");
                        break;
                }
            }

        }
        public static void AddBook(ArrayList bookslist, ArrayList authors, ArrayList price)
        {
            Console.Write("Enter a new title of book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            Console.Write("Enter the price of the book: ");
            double priceOfBook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{title} added to the list of Books");
            bookslist.Add(title);
            authors.Add(author);
            price.Add(priceOfBook);
           

        }
        public static void RemoveBook(ArrayList bookslist)
        {
            Console.Write("Enter the title of book you want to remove: ");
            string removeBook = Console.ReadLine();
             if (bookslist.Contains(removeBook))
            {
                bookslist.Remove(removeBook);
                Console.WriteLine($"{removeBook} removed from the list of books");
            }
             else
            {
                Console.WriteLine($"{removeBook} not fount in the list of books");
            }
        }
        public static void CalcTotalValue(ArrayList price)
        {
            double value = 0.00;
            foreach (double item in price)
            {
                value += item;
            }

            Console.WriteLine($"Total value of all books: {value}");
        }

    }



}