using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_3
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public static readonly double PI = (double)Math.PI;
        public double calculateArea()
        {
            return PI * (Radius * Radius);
        }

        public double calculatePerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
