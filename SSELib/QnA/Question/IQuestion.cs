using System;

namespace SSELib.QnA.Question
{
    public interface IQuestion
    {
        Options AnswerOptions { get; }

        int MustAnsweredOptions { get; }

        BaseAxis BaseAxis { get; }

        float Score { get; set; }

        bool UsingAudio { get; }

        string[,] OptionsText { get; }

        AnswerKeys AnswerKeys { get; set; }

        Type AnswersType { get; }
    }
}
