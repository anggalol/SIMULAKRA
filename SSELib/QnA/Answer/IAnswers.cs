using System.Collections.Generic;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;

namespace SSELib.QnA.Answer
{
    public interface IAnswers
    {
        bool IsDoubt { get; set; }

        int Count { get; }

        IList<int> IDs { get; }

        string DefaultAnswersValue { get; }

        void Add(int id, string answer);

        string[,] OptionsText { get; set; }

        string this[int id] { get; set; }


        // int CurrentScore { get; set; }

        AnswerBoxUserControl AnswerBox { get; }

        MetroCheckBox DoubtCheckBox { get; }
    }
}
