using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{

    abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
                        Console.WriteLine($"Area: {GetArea()}");

        }
    }

    // Q: When should you prefer an abstract class over an interface?
    // A: When you want to share common implementation or state across derived classes. 
    //    Abstract classes can provide both abstract members (to be overridden) 
    //    and concrete members (ready-to-use code).

}
