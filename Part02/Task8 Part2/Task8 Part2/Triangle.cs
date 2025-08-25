using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Part2
{
    public class Triangle : GeometricShape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override double GetPerimeter()
        {
           
            double side = Math.Sqrt(Math.Pow(BaseLength / 2, 2) + Math.Pow(Height, 2));
            return BaseLength + 2 * side;
        }
    }

}
