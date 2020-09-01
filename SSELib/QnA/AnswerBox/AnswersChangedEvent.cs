using System;

namespace SSELib.QnA.AnswerBox
{
    public delegate void AnswersChangedEventHandler(object sender, AnswersChangedEventArgs e);

    public class AnswersChangedEventArgs : EventArgs
    {
        public AnswersChangedEventArgs(int index, string newAnswer)
        {
            Index = index;
            NewAnswer = newAnswer;
        }

        public string NewAnswer { get; }

        public int Index { get; }
    }
}
