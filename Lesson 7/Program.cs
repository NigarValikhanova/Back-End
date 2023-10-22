using System.Collections;

namespace _17._08._2023_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StudentClass> StudentList = new List<StudentClass>();

            Console.WriteLine("Welcome to the register\n" +
                "For register you have to write your details \n" +
                "ID \n" +
                "Full name \n" +
                "Year of birth\n" +
                "Group No");


                Console.Write("Enter your name and surname please: ");
                string studentName = Console.ReadLine();
                Console.Write("Enter your ID which is given to you: ");
                int studentID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Emter your age: ");
                byte studentAge = Convert.ToByte(Console.ReadLine());
                Console.Write("Enter your group No: ");
                string studentGroupNo = Console.ReadLine();
                StudentClass studentN = new StudentClass(studentID, studentName, studentGroupNo, studentAge);
                StudentList.Add(studentN);
   

            int count = 0;
            foreach (StudentClass student in StudentList)
            {
                if (student.GroupNo == "AD-115")
                {
                    count++;

                }
            }
            Console.WriteLine(count);

            int total = 0;
            foreach (var student in StudentList)
            {
                if (student.FullName == studentName)
                {
                    total += student.GetBirthYear();

                }
            }
            Console.WriteLine(total);
        }
       
    }
    class StudentClass
    {

        public StudentClass(int anID, string aFullName, string aGroupNo, byte anAge)
        {
            Id = anID;
            FullName = aFullName;
            GroupNo = aGroupNo;
            Age  = anAge;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }

        public int GetBirthYear()
        {
            int currentYear = 2023;
            return currentYear - Age;
            
        }

    }


}