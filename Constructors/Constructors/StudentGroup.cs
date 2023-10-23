using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class StudentGroup
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; }

        public StudentGroup(string groupName)
        {
            GroupName = groupName;
            Students = new List<Student>(); 
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);   
        }

        public void GetStudents()
        {
            DisplayStudentCount();
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public int GetStudentCount()
        {
            return Students.Count;
        }

        public void DisplayStudentCount()
        {
            int count = GetStudentCount();
            Console.WriteLine($"Number of students in {GroupName}: {count}");
        }
    }
}
