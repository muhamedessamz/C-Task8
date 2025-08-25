using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{

    class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking via IWalkable interface.");
        }

        public void Walk()
        {
            Console.WriteLine("Robot walking in its own way.");
        }
    }

    // Q: How does explicit interface implementation help in resolving naming conflicts?
    // A: It allows the class to provide separate implementations for the same method name. 
    //    This resolves conflicts when a class has its own method with the same name as the interface method.

}
