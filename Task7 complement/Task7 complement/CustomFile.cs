using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_complement
{
    using System;

    class CustomFile : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading file...");
        }

        public void Write()
        {
            Console.WriteLine("Writing file...");
        }
    }

    // Q: How does C# overcome the limitation of single inheritance with interfaces?
    // A: Unlike classes, C# allows multiple interfaces to be implemented by a single class. 
    //    This provides flexibility and avoids the diamond problem present in multiple class inheritance.

}
