using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int StudentID { get; set; }

        public Student()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Age = 0;
            StudentID = 0;
        }
        public Student(string firstName, string lastName, int age, int studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            StudentID = studentID;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (Age: {Age}, ID: {StudentID})";
        }
    }
}
