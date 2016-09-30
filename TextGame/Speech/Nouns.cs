using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Items;

namespace TextGame.Speech
{
    namespace TextGame.Speech
    {
        public class Nouns : ISpeech
        {
            private Dictionary<string, string> _nouns;

            public static string CARD = "CARD";
            public Nouns()
            {
                _nouns = new Dictionary<string, string>();

                _nouns.Add(CARD, CARD);
            }

            public string GetSpeechFromInputString(string input)
            {
                if (string.IsNullOrWhiteSpace(input)) return null;

                input = input.ToUpper();

                string ret;
                _nouns.TryGetValue(input, out ret);

                return ret;
            }
        }

    }
}
