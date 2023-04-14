using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    internal interface IPerson
    {
        string Name { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
