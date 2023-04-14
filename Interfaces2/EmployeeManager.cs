using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added!");
        }

        public void Remove()
        {
            Console.WriteLine("Employee Removed!");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated!");
        }
    }
}
