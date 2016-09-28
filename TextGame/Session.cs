using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Session
    {
        private Inventory _inventory;
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Session()
        {
            _inventory = new Inventory();
        }

        private IItem _weildedItem;
        public IItem WeildedItem
        {
            get
            {
                return _weildedItem;
            }
            set
            {
                _weildedItem = value;
            }
        }
    }
}
