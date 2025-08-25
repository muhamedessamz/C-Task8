using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{
 
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        // Copy Constructor
        public Student(Student other)
        {
            Id = other.Id;
            Name = string.Copy(other.Name);
            Grade = other.Grade;
        }
    }

    // Q: What is the primary purpose of a copy constructor in C#?
    // A: To create a deep copy of an object so that modifications 
    //    in the copied object do not affect the original object.

}
