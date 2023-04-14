using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    internal class Employee : IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int TaxNumber { get; set; }
    }
}
