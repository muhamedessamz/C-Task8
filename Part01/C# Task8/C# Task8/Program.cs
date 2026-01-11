using C__Task8;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Book b1 = new Book();
        Book b2 = new Book("C# Programming");
        Book b3 = new Book("Clean Code", "Robert C. Martin");
        Console.WriteLine($"{b1.Title} - {b1.Author}");
        Console.WriteLine($"{b2.Title} - {b2.Author}");
        Console.WriteLine($"{b3.Title} - {b3.Author}");
    }
}
