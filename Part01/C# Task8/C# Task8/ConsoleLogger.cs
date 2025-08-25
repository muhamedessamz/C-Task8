using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console Logger: " + message);
        }
    }

}
