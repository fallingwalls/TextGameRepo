using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Constants
    {
        public Dictionary<string, Speech.Verbs> Verbs;
        public Constants()
        {
            Verbs = new Dictionary<string, Speech.Verbs>();
            Verbs.Add("GO", Speech.Verbs.Go);
            Verbs.Add("TAKE", Speech.Verbs.Take);
            Verbs.Add("DROP", Speech.Verbs.Drop);
        }
        
    }
}
