using SSELib.Answer;
using SSELib.Question;

namespace SSELib.Scoring
{
    public interface IQuestionScoring
    {
        float CalculateScore(IQuestion question, IAnswers answer);
    }
}
