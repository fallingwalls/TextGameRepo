using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using TextGame.Speech;
using TextGame.Speech.TextGame.Speech;

namespace TextGame
{
    public class Parser
    {
        private Verbs _verbs;
        private Nouns _nouns;

        public Parser()
        {
            _verbs = new Verbs();
            _nouns = new Nouns();
        }

        public KeyValuePair<string, string> Parse(string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return new KeyValuePair<string, string>();

            input = input.ToUpper();

            //check if theres expected input
            var r = new Regex(@"(.+)(\s)(.+)");
            var m = r.Match(input);

            if (m.Success)
            {
                var verb = _verbs.GetSpeechFromInputString(m.Groups[1].Value);
                return new KeyValuePair<string, string>(verb, m.Groups[3].Value);
            }

            //one word response
            r = new Regex(@".+");
            m = r.Match(input);

            if (m.Success)
            {
                //was it a verb?
                var verb = _verbs.GetSpeechFromInputString(input.Trim());
                if (verb != null) return new KeyValuePair<string, string>(verb, null);

                //was it a noun?
                var noun = _nouns.GetSpeechFromInputString(input.Trim());
                if (noun != null) return new KeyValuePair<string, string>(null, noun);
            }

            //i dont know what it is.
            return new KeyValuePair<string, string>();
        }
    }
}
