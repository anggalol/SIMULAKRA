using System.Collections.Generic;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;
using SSELib.QnA.Scoring;

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

        IQuestionScore QuestionScore { get; }

        AnswerBoxUserControl AnswerBox { get; }

        MetroCheckBox DoubtCheckBox { get; }
    }

    //public interface ITest
    //{
    //    bool IsDoubt { get; set; }

    //    int Count { get; }

    //    string DefaultAnswersValue { get; }

    //    IQuestion Question { get; }

    //    float CurrentScore { get; }

    //    string[,] OptionsText { get; }

    //    AnswerBoxUserControl AnswerBox { get; }
    //}

    //public class Biji : ITest
    //{
    //    public Biji()
    //    {
    //        AnswerBox = new MultipleAnswerAnswerBox();
    //        AnswerBox.UpdateOptions(OptionsText);
    //    }

    //    public bool IsDoubt { get; set; }

    //    public int Count => Question.MustAnsweredOptions;

    //    public string DefaultAnswersValue { get; }

    //    public IQuestion Question { get; }

    //    public float CurrentScore => new QnA.Scoring.MultipleAnswerScoring().CalculateScore(Question, this);

    //    public string[,] OptionsText => Question.OptionsText;

    //    public AnswerBoxUserControl AnswerBox { get; }
    //}
}
