using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void MaxMinF()
        {
            FileStream fs = new FileStream(@"D:\MaxMin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            string[] ss;
            s = sr.ReadLine();
            ss = s.Split(' ');
            int maxi = int.Parse(ss[0]);
            int mini = int.Parse(ss[0]);
            for (int i = 0; i < ss.Length; i++)
            {
                if (int.Parse(ss[i]) >= maxi)
                {
                    maxi = int.Parse(ss[i]);
                }
                if (int.Parse(ss[i]) <= mini)
                {
                    mini = int.Parse(ss[i]);
                }

            }

            Console.WriteLine("Max : " + maxi + "\nMin : " + mini);

        }
        static void Main(string[] args)
        {
            MaxMinF();
            Console.ReadKey();

        }
    }
}