using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonConstructor
{
    public class Person
    {
        private string firstName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } 
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, int age, string gender, string phoneNumber)
        {
            this.FirstName = name;
            this.Age = age;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
        }

        //public void SetFirstName(string newFirstName)
        //{
        //    FirstName = newFirstName;
        //}

        public void SetAge(int newAge)
        {
            Age = newAge;
        }

        public void SetGender(string newGender)
        {
            Gender = newGender;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }

        public void Print()
        {
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}

