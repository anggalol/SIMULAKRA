using SSELib.Question;
using SSELib.Answer;

namespace SSELib.Scoring
{
    public interface ITotalScore
    {
        float CalculateTotalScore(QuestionCollection qc, AnswersCollection ac, IQuestionScoring qscore);
    }
}
