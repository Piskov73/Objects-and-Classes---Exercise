
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class ListStudents
    {
        // First name(String)
        //	Last name(String)
        //•Grade(a floating-point number)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        //"{first name} {second name}: {grade}"
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<ListStudents> students = new List<ListStudents>(); 
            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countStudents; i++)
            {
                ListStudents newStudent=new ListStudents();
                string[] infoStudent=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                //"{first name} {second name} {grade}"
                string firstName = infoStudent[0];
                string lastName = infoStudent[1];
                double grade = double.Parse(infoStudent[2]);
                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                newStudent.Grade = grade;
                students.Add(newStudent);

            }
            List<ListStudents>filter=students.OrderByDescending(x=>x.Grade).ToList();
            foreach (var student in filter)
            {
                Console.WriteLine(student);
            }
        }
    }
}
