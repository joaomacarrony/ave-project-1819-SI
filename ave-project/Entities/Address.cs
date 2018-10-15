using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Address
    {
        public Address(string adress)
        {
            this.adress = adress;
        }

        public string adress { get; set; }
        public override string ToString()
        {
            return adress;
        }
    }
}
