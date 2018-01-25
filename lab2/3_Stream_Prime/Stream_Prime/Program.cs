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
            
            FileStream fr = new FileStream(@"D:\MaxMin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            string s = sr.ReadLine();

            string ans = " ";
            string[] ss;
            ss = s.Split(' ');

            var a = new List<int>();
            for (int j = 0; j < ss.Length; j++)
            {
                if (Prime(int.Parse(ss[j])) == true)
                    a.Add(int.Parse(ss[j]));
            }
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
                ans = ans + a[i] + " ";
            }
          
            sr.Close();
            fr.Close();
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

        public static void PrimeFun2()
        {
            FileStream fr = new FileStream(@"D:\answer.txt", FileMode.Open, FileAccess.Write);
            StreamReader sr = new StreamReader(fr);
        
    
                Console.WriteLine();
            
            sr.Close();
            fr.Close();
        }

        static void Main(string[] args)
        {
            PrimeFun1();
            //PrimeFun2();
            Console.ReadKey();

        }
    }
}