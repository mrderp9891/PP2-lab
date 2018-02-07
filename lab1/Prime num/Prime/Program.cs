using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine(num + " is not prime number");
                Console.ReadKey();
            }
            else
            {
                for (int i = 2; i <= num / 2; i++) 
                {
                    if (num % i == 0) 
                    {
                        Console.WriteLine(num + " is not prime number");
                        Console.ReadKey();
                        return;
                    }
                
                }
                Console.WriteLine(num + " is a prime number");
                Console.ReadKey();
            }
        }
    }
}
