using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Remove()
        {
            Console.WriteLine("Customer Removed!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
