using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    internal class PersonManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update (IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
