using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Parsing;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        private Session _session;
        private Parser _parser;
        public Program()
        {
            _session = new Session();
            _parser = new Parser();

            PrintIntro();

            while (true)
            {
                var input = Console.ReadLine();

                _parser.Parse(input);
            }
        }

        private void PrintIntro()
        {

        }

    }
}
