using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SSELib.AnswerKey
{
    public struct Key
    {
        public Key(string key)
            : this(null, key)
        {
        }

        public Key(Regex regex, string key)
        {
            KeyRegex = regex;
            AnswerKey = key;
        }

        public Regex KeyRegex { get; set; }

        public string AnswerKey { get; set; }
    }
}
