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
        public double gpa;
        public string n;
        public string g;


        public Student()
        {
            
            Fname = "Madi";
            Lname = "Abdykarim";
            gpa = 3.5;
            
            
        }
        public Student(string name,string GPA)
        {
            n = name;
            g = GPA;
        }
        public override string ToString()
        {
            return "Name is " + n + "\n"  + "GPA is " + g;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string GPA = Console.ReadLine();

            Student Student = new Student();
            Student Student2 = new Student(name, GPA);


           
          Console.WriteLine(Student2);



            Console.ReadKey();
        }
    }
}