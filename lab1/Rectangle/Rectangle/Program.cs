using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Rectangle
    {
        public int width;
        public int height;
        public int area;
        public int peri;
        

        public Rectangle()
        {
            Console.WriteLine("Width : ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height : ");
            height = int.Parse(Console.ReadLine());
            area = width * height;
            peri = 2 * (width + height);
        }

        public override string ToString()
        {
            return "Area : " + area + "\n" + "Perimeter : " + peri;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle R = new Rectangle();
            Console.WriteLine(R);

            Console.ReadKey();
        }
    }
}