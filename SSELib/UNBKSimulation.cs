using System;
using SSELib.Question;

namespace SSELib
{
    [Obsolete("Use AKMSimulation instead.")]
    public class UNBKSimulation : ISimulationType
    {
        public float MaxScore => 100f;

        public string[] AllowableQuestionTypes => new string[]
        {
            typeof(MultipleChoiceQuestion).AssemblyQualifiedName,
            typeof(ShortEntryQuestion).AssemblyQualifiedName
        };
    }
}
