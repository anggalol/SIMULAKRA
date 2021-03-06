﻿using System;
using SSELib.QnA.Question;

namespace SSELib.QnA
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
