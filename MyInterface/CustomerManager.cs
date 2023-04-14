using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    internal class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Delete()
        {
            Console.WriteLine ("Customer Deleted");
        }

        public void Update()
        {
           Console.WriteLine ("Customer Updated");
        }

        public void Log()
        {
            Console.WriteLine("Customer Logged in Database");
        }
    }
}
