using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Speech
{
    public class Verbs : ISpeech
    {
        private Dictionary<string, string> _verbs;


        public static string GO = "GO";
        public static string TAKE = "TAKE";
        public static string DROP = "DROP";
        public Verbs()
        {
            _verbs = new Dictionary<string, string>();

            _verbs.Add(GO, GO);
            _verbs.Add("WALK", GO);
            
            _verbs.Add(TAKE, TAKE);
            _verbs.Add("GET", TAKE);
            _verbs.Add("PICKUP", TAKE);

            _verbs.Add(DROP, DROP);

        }
        
        public string GetSpeechFromInputString(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            input = input.ToUpper();

            string ret;
            _verbs.TryGetValue(input, out ret);

            return ret;
        }
    }
}
