using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final1
{
    class Program
    {
        static void Main(string[] args)
        {
            int polindrom = 0;
          
            string fstring = "";
            string sstring = "";
            string sss = "";
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');

            for(int i = 0; i < ss.Length; i++)
            {
              
                sss = ss[i];
                if (sss.Length % 2 == 0)
                {

                    for (int j = 0; j < sss.Length / 2; j++)
                    {
                        fstring += sss[j];
                    }
                    for (int h = sss.Length - 1; h >= sss.Length / 2; h--)
                    {
                        sstring += sss[h];
                    }
                    if (fstring == sstring)
                    {
                        polindrom++;
                    }
                    Console.WriteLine(fstring + " " + sstring);
                    fstring = "";
                    sstring = "";
                }
                else
                {
                    for (int j = 0; j < sss.Length / 2; j++)
                    {
                        fstring += sss[j];
                    }
                    for (int h = sss.Length - 1; h > sss.Length / 2; h--)
                    {
                        sstring += sss[h];
                    }
                    if (fstring == sstring)
                    {
                        polindrom++;
                    }
                    Console.WriteLine(fstring + " " + sstring);
                    fstring = "";
                    sstring = "";
                }
            }

            Console.WriteLine(ss.Length);
            Console.WriteLine(polindrom);
            Console.ReadKey();
        }
    }
}
