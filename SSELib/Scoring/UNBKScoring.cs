using System;
using SSELib.Answer;
using SSELib.Question;

namespace SSELib.Scoring
{
    public class UNBKScoring : ITotalScore
    {
        public float CalculateTotalScore(QuestionCollection qc, AnswersCollection ac, IQuestionScoring qscore)
        {
            if (qc.Count != ac.Count)
                throw new ArgumentException();

            float scoreSum = 0;
            float totalScore = 0;
            foreach (int id in qc.Keys)
            {
                scoreSum += qscore.CalculateScore(qc[id], ac[id]);
                totalScore += qc[id].Score;
            }

            return scoreSum / totalScore * 100;
        }
    }
}
