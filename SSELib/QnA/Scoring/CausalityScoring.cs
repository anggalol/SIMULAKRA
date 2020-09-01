using System;
using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public class CausalityScoring : IQuestionScore
    {
        public float CalculateScore(IQuestion question, IAnswers answers)
        {
            if (question.AnswersType != answers.GetType())
                throw new ArgumentException("The answer type must match to the question type");

            int correctAnswer = 0;
            for (int i = 0; i <= 3; i++)
            {
                if (question.AnswerKeys[i].AnswerKey == answers[i])
                    correctAnswer++;
            }

            return (float)correctAnswer / 3 * question.Score;
        }
    }
}
