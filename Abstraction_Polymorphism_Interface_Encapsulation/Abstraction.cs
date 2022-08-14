using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Interface_Encapsulation
{
    //Person class is a main class.
    //Must be blocked creating instance from Person class cause it'll be unreasonable.
    //So we're tagging with "abstract" keyword
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    internal class Employee : Person
    {
        public void CountStock()
        {
            Console.WriteLine("Stock is counting...");
        }

    }

    internal class Manager : Person
    {
        public void SignDocument()
        {
            Console.WriteLine("Document is signing...");
        }
    }
}
