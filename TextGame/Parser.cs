using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextGame
{
    public class Parser
    {
        StreamReader _reader;
        String _input;
        
        public Parser()
        {
            _reader = new StreamReader();
        }

        public KeyValuePair<Speech.Verbs, Speech.Items> GetInput()
        {
            var input = Console.ReadLine();
            
            
        }
    }
}
