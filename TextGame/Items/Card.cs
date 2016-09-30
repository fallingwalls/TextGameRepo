using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Items
{
    class Card : IItem
    {
        public string Description { get; private set; }
        public bool IsTakeable { get; private set; }
        public bool IsWeildable { get; private set; }
    }
}
