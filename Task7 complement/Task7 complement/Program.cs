using System;
using Task7_complement;

class Program
{
    static void Main(string[] args)
    {
        /*// Problem 6: IShape
        IShape rect = new Rectangle(5, 10);
        rect.Draw();
        Console.WriteLine($"Rectangle Area: {rect.Area}");*/
        

       /* // Problem 7: Default Implementation
        IShape2 circle = new Circle(7);
        circle.Draw();
        circle.PrintDetails();*/
      

      /*  // Problem 8: Interface Reference
        IMovable movableCar = new CarMovable();
        movableCar.Move();*/
        

      
        // Problem 9: Multiple Interfaces
        CustomFile customFile = new CustomFile();
        customFile.Read();
        customFile.Write();

    }
}
