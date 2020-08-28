using System;
using System.Collections.Generic;

namespace SSELib.Answer
{
    public interface IAnswers
    {
        bool IsDoubt { get; set; }

        int Length { get; set; }

        IList<int> IDs { get; }

        string DefaultAnswersValue { get; }

        void Add(int id, string answer);

        string this[int id] { get; set; }
    }
}
