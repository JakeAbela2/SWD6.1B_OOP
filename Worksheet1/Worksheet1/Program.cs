using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) --> object is when you create a space in memory and you start assigning values to the template you created earlier
            
            //Circle Area
            Circle c = new Circle(/*5, "black"*/); //e.g. of an  object --> c
            
            c.Radius = 5;

            Console.WriteLine("Area of Circle");
            Console.WriteLine();
            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}, Perimeter is {Math.Round(c.GetPerimeter()), 2}");

            Console.WriteLine();

            //Rectangle Area
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Rectangle r3 = new Rectangle();

            Console.WriteLine("Areas of Rectangles");
            Console.WriteLine();
            Console.WriteLine("Input a length: ");
            r1.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input a width: ");
            r1.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input a length: ");
            r2.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input a width: ");
            r2.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input a length: ");
            r3.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input a width: ");
            r3.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {Math.Round(r1.RectArea(), 2)}, Perimeter is {Math.Round(r1.RectPerimeter()),2}");
            Console.WriteLine($"Area is {Math.Round(r2.RectArea(), 2)}, Perimeter is {Math.Round(r2.RectPerimeter()),2}");
            Console.WriteLine($"Area is {Math.Round(r3.RectArea(), 2)}, Perimeter is {Math.Round(r3.RectPerimeter()),2}");

            Console.WriteLine("Press a key to terminate");
            Console.ReadKey();
        }
    }
}
