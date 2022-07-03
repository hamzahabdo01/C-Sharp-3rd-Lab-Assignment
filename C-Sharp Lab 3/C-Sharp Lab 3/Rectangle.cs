using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_3 
{ 
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public double calculateArea()
        {
            return Length * Width;
        }

        public double calculatePerimeter()
        {
            return 2 * (Length + Width);
        }
}
}
