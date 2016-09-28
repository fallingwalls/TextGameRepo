using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    interface IArea
    {
        string LongDescription {get;}
        string ShortDescription { get; }

        Session GameSession { get; }
    }
}
