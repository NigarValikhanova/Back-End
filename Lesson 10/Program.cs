namespace _28._08._2023_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("SLJackson@gmail.com", "SamuelJack585");
            user.FullName = "Samuel L.Jackson";
            user.PasswordChecker(user.Password);
            user.ShowInfo(user.FullName, user.Email);
        }
    }
    public abstract class Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Account(string email, string password)
        {
            Email = email;
            Password = password;

        }
        public bool PasswordChecker(string Password)
        {
            bool Letter = false;
            bool Digit = false;
            
            if (Password.Length <= 8)
            {
                Console.WriteLine("Your password must be minimum 8 characters");
            }
            else
            {
                foreach (char item in Password)
                {
                    if ((int)item >= 65 && (int)item <= 90 || (int)item >= 97 && (int)item <= 122)
                    {
                        Letter = true;
                    }
                    else if ((int)item >= 48 && (int)item <= 57)
                    {
                        Digit = true;
                        
                    }
                }
                if (Digit == true && Letter == true)
                {
                    Console.WriteLine("Your password is not correct");
                }
                return true;
                

            }
            Console.WriteLine("Your password is correct");
            return true;
            
        }

        public virtual void ShowInfo (string Fullname, string Email)
        {
            Console.WriteLine($"Your full name is {Fullname} and your email is {Email}");
        }
    }
    public class User : Account
    {
        public User( string mail, string psswrd) :base(mail, psswrd) { }
    }
}