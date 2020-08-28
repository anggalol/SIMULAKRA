using System;
using SSELib.Question;

namespace SSELib
{
    public class AKMSimulation : ISimulationType
    {
        public float MaxScore => 100f;

        public string[] AllowableQuestionTypes => null;
    }
}
