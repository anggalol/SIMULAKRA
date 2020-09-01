using System;
using SSELib.QnA.Question;

namespace SSELib.QnA
{
    public class UTBKSimulation : ISimulationType
    {
        public float MaxScore { get; set; }

        public string[] AllowableQuestionTypes => new string[] { typeof(MultipleChoiceQuestion).AssemblyQualifiedName };
    }
}
