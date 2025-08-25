using C__Task8;
using System;

class Program
{
    static void Main(string[] args)
    {
        /*// Problem 1: Interface
        IVehicle car = new Car();
        IVehicle bike = new Bike();
        car.StartEngine(); car.StopEngine();
        bike.StartEngine(); bike.StopEngine();*/


        /*// Problem 2: Abstract Class
        Shape rect = new Rectangle(5, 10);
        Shape circle = new Circle(7);
        rect.Display();
        circle.Display();*/

        

       /* // Problem 3: IComparable
        Product[] products = {
            new Product(1, "Laptop", 1200m),
            new Product(2, "Phone", 800m),
            new Product(3, "Tablet", 500m)
        };
        Array.Sort(products);
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - {p.Price}");*/



       /* // Problem 4: Copy Constructor
        Student s1 = new Student(1, "Ahmed", 90.5);
        Student s2 = s1; // shallow copy
        Student s3 = new Student(s1); // deep copy
        s2.Name = "Ali";
        Console.WriteLine($"Original after shallow change: {s1.Name}");
        Console.WriteLine($"Deep copy unaffected: {s3.Name}");*/



       /* // Problem 5: Explicit Interface
        Robot robot = new Robot();
        robot.Walk();
        ((IWalkable)robot).Walk();*/



       /* // Problem 6: Struct
        Account acc = new Account { AccountId = 1, AccountHolder = "Mohamed", Balance = 5000 };
        Console.WriteLine($"ID: {acc.AccountId}, Holder: {acc.AccountHolder}, Balance: {acc.Balance}");*/



       /* // Problem 7: Default Interface Implementation
        ILogger logger = new ConsoleLogger();
        logger.Log("System started.");*/

        

        // Problem 8: Constructor Overloading
        Book b1 = new Book();
        Book b2 = new Book("C# Programming");
        Book b3 = new Book("Clean Code", "Robert C. Martin");
        Console.WriteLine($"{b1.Title} - {b1.Author}");
        Console.WriteLine($"{b2.Title} - {b2.Author}");
        Console.WriteLine($"{b3.Title} - {b3.Author}");
    }
}
