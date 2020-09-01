using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public interface ISimulationScore
    {
        float CalculateTotalScore(QuestionCollection qc, AnswersCollection ac);
    }
}
