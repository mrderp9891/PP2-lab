using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        
        public static void PrimeFun1()
        {
            string s = File.ReadAllText(@"D:\prime.txt");
            
            string[] ss;
            ss = s.Split(' ');

            var a = new List<int>();
            
            for (int j = 0; j < ss.Length; j++)
            {
                if (Prime(int.Parse(ss[j])) == true)
                    a.Add(int.Parse(ss[j]));
            }
            int min = a[0];
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= min)
                {
                    min = a[i];
                }
            }
                 Console.WriteLine(min);
                 string mystring = min.ToString();
                 File.WriteAllText(@"D:\answer.txt", mystring);
            
        }

        public static bool Prime(int a)
        {
            bool isprime = true;
            if (a < 2)
            {
                isprime = false;
            }
            if (a == 2)
            {
                isprime = true;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }


        static void Main(string[] args)
        {
            PrimeFun1();

            Console.ReadKey();
        }
    }
}