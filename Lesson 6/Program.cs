using System.Collections;

namespace Task_14._08._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList();

            while (true)
            {
                Console.WriteLine("Shopping List");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Items by Category");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddItem(shoppingList);
                        break;

                    case 2:
                        DisplayItemsByCategory(shoppingList);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
        public static void AddItem(ArrayList arrayList)
        {
            Console.Write("Enter the item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter the item category: ");
            string itemCategory = Console.ReadLine();

            Console.Write("Enter the item price: ");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            var item = new
            {
                Name = itemName,
                Category = itemCategory,
                Price = itemPrice
            };

            ArrayList shoppingList = new ArrayList();
            shoppingList.Add(item);

            Console.WriteLine($"Item '{itemName}' added to the shopping list.");
        }
        
        static void DisplayItemsByCategory(ArrayList shoppingList)
        {
            Console.Write("Enter the category to display: ");
            string categoryToDisplay = Console.ReadLine();

            Console.WriteLine($"Items in the '{categoryToDisplay}' category:");
            foreach (var item in shoppingList)
            {
                var typedItem = (item as dynamic);
                if (typedItem.Category == categoryToDisplay)
                {
                    Console.WriteLine($"Name: {typedItem.Name}, Price: {typedItem.Price}");
                }
            }

        }
    }
}