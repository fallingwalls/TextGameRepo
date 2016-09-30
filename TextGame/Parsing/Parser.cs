using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TextGame.Speech;
using TextGame.Speech.TextGame.Speech;

namespace TextGame.Parsing
{
    public class Parser
    {
        private Verbs _verbs;
        private Nouns _nouns;

        public delegate void RaiseMenuCaseRequested(string requestCase);

        public event RaiseMenuCaseRequested MenuCaseRequested;

        public Parser()
        {
            _verbs = new Verbs();
            _nouns = new Nouns();
        }

        public ParseResponse Parse(string input)
        {
            var response = new ParseResponse();

            if (String.IsNullOrWhiteSpace(input)) return new ParseResponse();

            input = input.ToUpper().Trim();

            //check if theres expected input
            var r = new Regex(@"(.+)(\s)(.+)");
            var m = r.Match(input);

            if (m.Success)
            {
                var verb = _verbs.GetSpeechFromInputString(m.Groups[1].Value);
                var predicate = m.Groups[3].Value;
                return new ParseResponse
                {
                    Verb = verb,

                };
                return new KeyValuePair<string, string>(verb, m.Groups[3].Value);
            }

            //one word response
            r = new Regex(@".+");
            m = r.Match(input);

            if (m.Success)
            {
                //was it a verb?
                var verb = _verbs.GetSpeechFromInputString(input);
                if (verb != null) return new KeyValuePair<string, string>(verb, null);

                //was it a noun?
                var noun = _nouns.GetSpeechFromInputString(input);
                if (noun != null) return new KeyValuePair<string, string>(null, noun);

                //is it a menu case?
                switch (input)
                {
                    case Constants.HELP:
                        MenuCaseRequested(Constants.HELP);
                        break;
                }
            }

            //i dont know what it is.
            return new KeyValuePair<string, string>();
        }

        private void CheckSpeechType(string input, ParseResponse response)
        {
            //was it a verb?
            var verb = _verbs.GetSpeechFromInputString(input);
            if (verb != null)
            {
                response.Verb = verb;
                return;
            }

            CheckPredicateType(input, response);
        }

        private void CheckPredicateType(string input, ParseResponse response)
        {
            //was it a noun?
            var noun = _nouns.GetSpeechFromInputString(input);
            if (noun != null) return new KeyValuePair<string, string>(null, noun);

            //is it a menu case?
            switch (input)
            {
                case Constants.HELP:
                    MenuCaseRequested(Constants.HELP);
                    break;
            }
        }
    }
}
