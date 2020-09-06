using System;
using System.Xml;
using System.Xml.Serialization;

namespace SSELib.QnA
{
    public class SimulationHeader
    {
        [XmlAttribute]
        public string Version { get; set; }

        public string Title { get; set; }

        public int Time { get; set; }

        public int QuestionCount { get; set; }

        public bool RandomizeQuestion { get; set; }

        public DateTime? StartDateTime { get; set; }

        public bool StartDateTimeDependent { get; set; }

        public string QuestionFile { get; set; }

        public string SimulationType { get; set; }
    }
}
