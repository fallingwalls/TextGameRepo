using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TextGame;
using TextGame.Parsing;
using TextGame.Speech;
using TextGame.Speech.TextGame.Speech;

namespace TestApplication
{
    class Program
    {
        private Parser _parser;
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            _parser = new Parser();

            var one = _parser.Parse("drop card");
            if (!one.Key.Equals(Verbs.DROP) || !one.Value.Equals("CARD"))
            {
                throw new Exception();
            }
            Console.WriteLine("Test 1 - Pass");

            var two = _parser.Parse("GET CARD");
            if (!two.Key.Equals(Verbs.TAKE) || !two.Value.Equals("CARD"))
            {
                throw new Exception();
            }
            Console.WriteLine("Test 2 - Pass");

            var three = _parser.Parse("GET");
            if (!three.Key.Equals(Verbs.TAKE) || three.Value != null)
            {
                throw new Exception();
            }
            Console.WriteLine("Test 3 - Pass");

            var four = _parser.Parse("CARD");
            if (four.Key != null || !four.Value.Equals(Nouns.CARD))
            {
                throw new Exception();
            }
            Console.WriteLine("Test 4 - Pass");

            var five = _parser.Parse("card");
            if (five.Key != null || !five.Value.Equals(Nouns.CARD))
            {
                throw new Exception();
            }
            Console.WriteLine("Test 5 - Pass");

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
