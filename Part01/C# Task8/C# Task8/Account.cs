using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{
   struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;

        public int AccountId
        {
            get => accountId;
            set => accountId = value;
        }

        public string AccountHolder
        {
            get => accountHolder;
            set => accountHolder = value;
        }

        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }
    }

    // Q: What is the key difference between encapsulation in structs and classes? 
    // A: Structs are value types (stored on the stack) while classes are reference types (stored on the heap). 
    //    Encapsulation works the same way, but structs are more lightweight and usually used for small data containers.

}
