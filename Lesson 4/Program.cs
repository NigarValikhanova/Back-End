using System.Collections;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Previous task
            //string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            //string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            //string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            //int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };
            //The first part of the task
            //for(int i = 0; i < bookTitles.Length; i++)
            //{
            //    Console.WriteLine($"{bookTitles[i]}: {bookAuthors[i]}: {bookGenres[i]} : {bookCopiesAvailable[i]}");
            //}
            // The second part of the task
            //Console.WriteLine("Enter a book title:");
            //string input = Console.ReadLine().ToUpper();
            //for (int i = 0; i < bookTitles.Length; i++) 
            //{
            //    if (input == bookTitles[i].ToUpper()) 
            //    {
            //        Console.WriteLine($"{bookTitles[i]}: {bookAuthors[i]}: {bookGenres[i]} : {bookCopiesAvailable[i]}");
            //    }            
            //}

            // the third part of the task
            //string book = Console.ReadLine();

            //for (int i = 0; i < bookTitles.Length; i++)
            //{
            //    if (book == bookTitles[i])
            //    {
            //        if (bookCopiesAvailable[i] > 0)
            //        {
            //            Console.WriteLine("Book is available to borrow");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Book is not available");
            //        }
            //    }
            //}


            #endregion

            #region Shopping List ArrayList   
            ArrayList shoppingList = new ArrayList();
            Console.WriteLine("How many item you wanna add to the list?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Add a new item on your shopping list");
                string itemOfShoppingList = Console.ReadLine();
                shoppingList.Add(itemOfShoppingList);
            }

            Console.WriteLine("List of Shopping");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Would you like to check your list? Then enter the name of item");
            string itemToCheck = Console.ReadLine();

            bool exists = shoppingList.Contains(itemToCheck);
            if (exists)
            {
                Console.WriteLine($"The {itemToCheck} exists on the Shopping List");
            }
            else
            {
                Console.WriteLine($"The {itemToCheck} does not exist on your list");
                Console.WriteLine("Would you like to add this item on your list?");
                bool yes = Console.ReadLine() == "yes";
                if (yes)
                {
                    shoppingList.Add(itemToCheck);
                }


            }

            Console.WriteLine("Your updated shopping list located below");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
    }
}