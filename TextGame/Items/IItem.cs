using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    interface IItem
    {
        string Description { get; }
        bool IsTakeable { get; }
        bool IsWeildable { get; }
    }
}
