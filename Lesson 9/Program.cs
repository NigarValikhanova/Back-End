namespace QuizTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewMethods.checkingmethod());
        }

    }
    static class NewMethods
    { 
        //my quiz task
        public static bool checkingmethod()
        {
            Console.WriteLine("Enter the something you want to check");
            string something = Console.ReadLine();

            bool Digit = false;
            bool Letter = false;
            foreach (char item in something)
            {
                if ((int)item >= 65 && (int)item <= 90 || (int)item >= 97 && (int)item <= 122)
                {
                    Letter = true;
                }
                if ((int)item >= 48 && (int)item <= 57)
                {
                    Digit = true;
                }

            }
            if (Digit == true && Letter == true)
            {
                return true;
            }
            return false;
        }
    }
}