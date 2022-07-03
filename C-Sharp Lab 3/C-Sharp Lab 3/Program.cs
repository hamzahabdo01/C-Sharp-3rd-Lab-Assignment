using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            Console.WriteLine("To find rectangle (1), to find circle (2): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Length:");
                r.Length = int.Parse(Console.ReadLine());
                Console.WriteLine("Width:");
                r.Width = int.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + r.calculateArea());
                Console.WriteLine("Perimeter: " + r.calculatePerimeter());

            }
            else if(choice == 2)
            {
                Console.WriteLine("Radius:");
                c.Radius = int.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + c.calculateArea());
                Console.WriteLine("Perimeter: " + c.calculatePerimeter());
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
