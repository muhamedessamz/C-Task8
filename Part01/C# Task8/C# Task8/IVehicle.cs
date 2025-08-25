using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{
    interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    // Q: Why is it better to code against an interface rather than a concrete class?
    // A: Because interfaces define contracts, not implementations. 
    //    This allows flexibility, polymorphism, and easier testing since 
    //    you can swap implementations without changing client code.

}
