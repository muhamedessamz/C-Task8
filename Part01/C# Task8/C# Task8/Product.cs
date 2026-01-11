using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{


    class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = ame;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }

    // Q: How does implementing IComparable improve flexibility in sorting?
    // A: It allows custom comparison logic (e.g., by Price, Name, or Id). 
    //    This makes sorting objects with Array.Sort or LINQ seamless 
    //    without writing external comparison code every time.

}
