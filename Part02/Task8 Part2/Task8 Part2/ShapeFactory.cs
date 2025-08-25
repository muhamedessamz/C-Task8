using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Part2
{
    public class ShapeFactory
    {
        public static GeometricShape CreateShape(string type, params double[] values)
        {
            switch (type.ToLower())
            {
                case "triangle":
                    return new Triangle(values[0], values[1]);
                case "rectangle":
                    return new Rectangle(values[0], values[1]);
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

}
