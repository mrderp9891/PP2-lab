using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Complex
{

    class Complex
        {
            public void C1(int a, int b)
            {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
             public void C1(int a, int b, int c)
            {
            Console.WriteLine(a + " + " + b + " + " + c + " = " + (a + b + c));
            }
    }
    
    class Program
    {   
        static void Main(string[] args)
        {
            Complex Com = new Complex();
            Com.C1(4, 7);
            Com.C1(5, 3, 4);
            Console.ReadKey();
        }
    }
}
