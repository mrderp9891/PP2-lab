using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Final2
{
    class Program
    {
        static void ShowState(DirectoryInfo dir)
        {
            string s = "";
            
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            for(int i = 0; i < infos.Length; i++)
            {
                s = File.ReadAllText(infos[i].FullName);
                string[] ss = s.Split(' ');
                for (int j = 0; j < ss.Length; j++)
                {
                    
                    if (IsPrime(int.Parse(ss[j])))
                    {
                        Console.WriteLine(infos[i]);
                    }
                }
               
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Doge\qwerty");
            ShowState(dir);
           
            Console.ReadKey();
        }

        public static bool IsPrime(int a)
        {
            bool prime = false;
            if(a < 2)
            {
                prime = false;   
            }
            if (a == 2)
            {
                prime = true;
            }
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    prime = false;
                    break;
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }
    }
}
