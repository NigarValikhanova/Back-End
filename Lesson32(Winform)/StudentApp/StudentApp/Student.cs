using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Score { get; set; }

        public Student(string name, string surname, string city, string score)
        {
            Name = name; 
            Surname = surname; 
            City = city; 
            Score = score;
        }       
    }
}
