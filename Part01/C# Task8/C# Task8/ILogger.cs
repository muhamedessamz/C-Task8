using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{
 
    interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine("Default Log: " + message);
        }
    }

    // Q: How do default interface implementations affect backward compatibility in C#?
    // A: They allow adding new methods to an interface without breaking existing classes. 
    //    Existing classes keep working with the default implementation until they override it.

}
