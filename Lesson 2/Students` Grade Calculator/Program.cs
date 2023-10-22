using System.ComponentModel.Design;

namespace Student_s_grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Enter your score, please");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your score is C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Your score is D");
            }
            else if (score >= 0)
            {
                Console.WriteLine("Your score is E");
            }

            Console.WriteLine("Hope your score satisfies you");
            Console.ReadLine();


        }
    }
}