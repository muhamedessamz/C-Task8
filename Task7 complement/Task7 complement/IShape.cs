using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_complement
{
    interface IShape
    {
        double Area { get; }
        void Draw();
    }

    // Q: Why can't you create an instance of an interface directly?
    // A: Because an interface only defines a contract (methods/properties) 
    //    without providing implementation. You must implement it in a class 
    //    before creating an instance.

}
