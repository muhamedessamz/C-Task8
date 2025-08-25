using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_complement
{

    interface IShape2
    {
        double Area { get; }
        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape with Area = {Area}");
        }
    }

    // Q: What are the benefits of default implementations in interfaces introduced in C# 8.0?
    // A: They allow developers to add new members to interfaces without breaking existing code. 
    //    Existing classes automatically inherit the default behavior, while still having the option to override it.

}
