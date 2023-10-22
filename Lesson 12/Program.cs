using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Pharmacy pharmacy = new Pharmacy();

        Medicine medicine1 = new Medicine("Nimesil", 4.0, 100);
        Medicine medicine2 = new Medicine("Majezik", 5.0, 50);
        Medicine medicine3 = new Medicine("TylerHot", 5.5, 200);

        pharmacy.AddMedicine(medicine1);
        pharmacy.AddMedicine(medicine2);
        pharmacy.AddMedicine(medicine3);

        //pharmacy.Sell("Nimesil", 30);
        //pharmacy.Sell("Majezik", 20);
        //pharmacy.Sell("TylerHot", 70);

        Console.WriteLine("Total Income: " + pharmacy.TotalIncome);
    }
}

class Medicine
{
    public string Name { get; }
    public double Price { get; }
    public int Count { get; private set; }

    public Medicine(string name, double price, int count)
    {
        if (string.IsNullOrWhiteSpace(name) || price <= 0 || count < 0)
            throw new ArgumentException("Information is wrong");

        Name = name;
        Price = price;
        Count = count;
    }

    public void Sell(int sellCount)
    {
        if (sellCount <= 0)
            throw new ArgumentException("Count of sales must be bigger than 0");
        if (sellCount > Count)
            throw new InvalidOperationException("There is not enough count of medicine in the warehouse");

        Count -= sellCount;
        Console.WriteLine("Remained: " + Count);
        //bunu bura yazmagimda sebeb sell methodunu cagiranda burdan da azalma gedib getmediyini yoxlamaqdi
    }
}
class Pharmacy
{
    private List<Medicine> Medicines { get; }
    public double TotalIncome { get; private set; }

    public Pharmacy()
    {
        Medicines = new List<Medicine>();
    }

    public Medicine FindMedicineByName(string name)
    {
        return Medicines.Find(medicine => medicine.Name == name);
    }

    public void AddMedicine(Medicine medicine)
    {
        if (FindMedicineByName(medicine.Name) != null)
            throw new InvalidOperationException("There is a drug with the same name.");

        Medicines.Add(medicine);
    }

    public void Sell(string name, int sellCount)
    {
        Medicine medicine = FindMedicineByName(name);

        if (medicine == null)
            throw new ArgumentException("No medicine was found with this name");

        medicine.Sell(sellCount);
        TotalIncome += medicine.Price * sellCount;
    }
}
