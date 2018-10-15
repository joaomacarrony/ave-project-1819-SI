using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class School
    {
        public School(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string name { get; set; }
        public Address address { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
