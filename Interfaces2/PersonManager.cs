using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class PersonManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Remove(IPersonManager personManager)
        {
            personManager.Remove();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
