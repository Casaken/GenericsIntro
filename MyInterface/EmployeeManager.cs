using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    internal class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
        public void Log()
        {
            Console.WriteLine("Employee Logged in Database");
        }

        public void Change()
        {
            Console.Write("Employee Changed");
        }
    }
}
