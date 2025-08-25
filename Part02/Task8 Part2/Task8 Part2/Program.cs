using System;
using System.Collections.Generic;
using Task8_Part2;

class Program
{
    static void Main(string[] args)
    {
        // IShapeSeries usage
        IShapeSeries square = new SquareSeries(5);
        IShapeSeries circle = new CircleSeries(3);

        Console.WriteLine($"Square -> Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
        Console.WriteLine($"Circle -> Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");

        // GeometricShape usage with Factory
        GeometricShape triangle = ShapeFactory.CreateShape("triangle", 6, 4);
        GeometricShape rectangle = ShapeFactory.CreateShape("rectangle", 5, 7);

        Console.WriteLine($"Triangle -> Area: {triangle.GetArea()}, Perimeter: {triangle.GetPerimeter()}");
        Console.WriteLine($"Rectangle -> Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");

        // Using Shape with IComparable
        List<Shape> shapes = new List<Shape>
        {
            new Shape("Square", square.CalculateArea()),
            new Shape("Circle", circle.CalculateArea()),
            new Shape("Triangle", triangle.GetArea()),
            new Shape("Rectangle", rectangle.GetArea())
        };

        shapes.Sort();

        Console.WriteLine("\nSorted Shapes by Area:");
        foreach (var s in shapes)
        {
            Console.WriteLine(s);
        }
    }
}
