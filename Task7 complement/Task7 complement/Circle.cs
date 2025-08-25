using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_complement
{

    class Circle : IShape2
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public void Draw()
        {
            Console.WriteLine($"Drawing Circle with radius = {Radius}");
        }
    }

}
