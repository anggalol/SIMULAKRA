using System;
using SSELib.Question;

namespace SSELib
{
    public class UTBKSimulation : ISimulationType
    {
        public float MaxScore { get; set; }

        public string[] AllowableQuestionTypes => new string[] { typeof(MultipleChoiceQuestion).AssemblyQualifiedName };
    }
}
