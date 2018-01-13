using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Circle
{
    class Circle
    {
        public int radius;
        public double area;
        public int diam;
        public double circ;


        public Circle()
        {
            Console.WriteLine("Radius : ");
            radius = int.Parse(Console.ReadLine());

            area = 3.14 * (radius * radius);
            diam = 2 * radius;
            circ = 3.14 * diam;
        }

        public override string ToString()
        {
            return "Area : " + area + "\n" + "Diameter : " + diam + "\n" + "Circumference : " + circ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Circle C = new Circle();
            Console.WriteLine(C);

            Console.ReadKey();
        }
    }
}