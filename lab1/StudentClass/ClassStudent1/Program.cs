using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string Fname;
        public string Lname;
        public string gpa;

        public Student()
        {
            Console.WriteLine("First name : ");
            Fname = Console.ReadLine();
            Console.WriteLine("Last name : ");
            Lname = Console.ReadLine();
            Console.WriteLine("GPA : ");
            gpa = Console.ReadLine();
            Console.Clear();
        }

        public override string ToString()
        {
            return "First name is " + Fname + "\n" + "Last name is " + Lname + "\n" + "GPA is " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
       
          Student Student = new Student();
          Console.WriteLine(Student);



            Console.ReadKey();
        }
    }
}