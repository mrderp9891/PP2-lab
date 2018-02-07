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
            width = 1;
            height = 1;
            area = 0;
            peri = 0;
        }

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public void FindArea()
        {
            area = width * height;
        }
        public void FindPerimeter()
        {
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
            Console.WriteLine("Width : ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height : ");
            int height = int.Parse(Console.ReadLine());

            Rectangle R = new Rectangle(width, height);
            R.FindArea();
            R.FindPerimeter();
            Console.WriteLine(R);

            Console.ReadKey();
        }
    }
}