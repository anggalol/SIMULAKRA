using System;

namespace SSELib.AnswerBox
{
    public delegate void AnswersChangedEventHandler(object sender, AnswersChangedEventArgs e);

    public class AnswersChangedEventArgs : EventArgs
    {
        public AnswersChangedEventArgs(string newAnswer)
        {
            NewAnswer = newAnswer;
        }

        public string NewAnswer { get; private set; }
    }
}
