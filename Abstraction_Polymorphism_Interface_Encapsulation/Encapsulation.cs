using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Polymorphism_Interface_Encapsulation
{
    //Is declaring as private the users name and we're encapsulating with another public name property
    internal class User
    {
        private string Name { get; set; }
        public bool Gender { get; set; }
        public string name
        {
            get
            {
                if (Gender)
                    return Name + " Bey";

                return Name + " Hanım";
            }
            set
            {
                this.Name = value;
            }
        }
    }
}
