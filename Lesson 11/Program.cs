using System.Diagnostics;

namespace Task_31._08._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pharmacy medicine1 = new Pharmacy("Nimesil", 1.7);
            Pharmacy medicine2 = new Pharmacy("Majezik", 2.4);
            Pharmacy medicine3 = new Pharmacy("Paracitamol", 1.6);
            List<Pharmacy> medicines = new List<Pharmacy>();
            medicines.Add(medicine1);
            medicines.Add(medicine2);
            medicines.Add(medicine3);


            medicine1.Count = 15;
            medicine2.Count = 25;
            medicine3.Count = 10;
            medicine3.SellCount = 4;
            medicine2.SellCount = 2;
            medicine1.SellCount = 3;
            medicine1.totalIncome();
            

        }
    }
    public class Pharmacy
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int SellCount { get; set; }
        public List<Pharmacy> Medicine { get; set; }
        public Pharmacy (string aName, double aPrice)
        {
            Name = aName; 
            Price = aPrice;
        }
        public void DecreaseCount()
        {
            if (SellCount < 0)
            {
                Console.WriteLine("Quantity must be greater than or equal to 0.");
            }

            if (Count < SellCount)
            {
                Console.WriteLine("Insufficient quantity in stock.");
            }

            Count -= SellCount;
        }
        public List<Pharmacy> Medicines = new List<Pharmacy>();
        
        public double TotalIncome
        {
            get
            {
                return _totalIncome;
            }
        }
        private double _totalIncome;
        public double totalIncome()
        {
            double sellPrice = 0;
            sellPrice = SellCount * Price;
            _totalIncome += SellCount;
            Count -= SellCount;
            Console.WriteLine(sellPrice + " manat is your price");
            Console.WriteLine(Count + " is remained");
            return _totalIncome;

        }
        public Pharmacy FindMedicineByName(string Name)
        {
            return Medicines.Find(m => m.Name == Name);
        }
        public void AddMedicine(Pharmacy medicine)
        {
            if (Medicines.Exists(m => m.Name == medicine.Name))
            {
                throw new InvalidOperationException("Medicine with the same name already exists in the pharmacy.");
            }

            Medicines.Add(medicine);
        }
    }
    static class Validation
    {
        public static bool NullOrEmpty(string value)
        {
            if (value.Trim() == null || value.Trim() == "")
            {
               return false;
            }
            return true;
        }
        public static bool NullOrEmpty (double price)
        {
            if (price <= 0)
            {
                return false;
            }
            return true;
        }
        public static bool NullOrEmpty(int count)
        {
            if (count <= 0)
            {
                return false;
            }
            return true;
        }
    }

}