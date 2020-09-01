using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public interface IQuestionScore
    {
        float CalculateScore(IQuestion question, IAnswers answers);
    }
}
