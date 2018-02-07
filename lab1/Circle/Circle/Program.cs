using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Circle
{
    public class Circle
    {
        public int radius;
        public double area;
        public double diam;
        public double circ;


        public Circle()
        {
            radius = 1;
            area = 0;
            diam = 0;
            circ = 0;
        }
        
        public Circle(int a)
        {
            radius = a;
        }
        public void FindArea()
        {
            area = Math.PI * (radius * radius);
        }
        public void FindDiameter()
        {
            diam = 2 * radius;
        }
        public void FindCircumference()
        {
            circ = 2 * Math.PI * radius;
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
            Console.WriteLine("Radius : ");
            Circle c = new Circle(int.Parse(Console.ReadLine()));
            
            c.FindArea();
            c.FindDiameter();
            c.FindCircumference();

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}