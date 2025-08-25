using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_complement
{
  
    interface IMovable
    {
        void Move();
    }

    // Q: Why is it useful to use an interface reference to access implementing class methods?
    // A: Because it allows polymorphism. You can work with different objects through a common contract 
    //    without depending on their specific class implementation.

}
