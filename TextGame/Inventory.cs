using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Inventory
    {
        private List<IItem> _inventory;

        public Inventory()
        {
            _inventory = new List<IItem>();
        }

        public void Add(IItem item)
        {
            _inventory.Add(item);
        }

        public void Remove(IItem item)
        {
            if (_inventory.Contains(item))
            {
                _inventory.Remove(item);
            }
        }
    }
}
