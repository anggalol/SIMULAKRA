using System;
using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public class TrueOrFalseScoring : IQuestionScore
    {
        public float CalculateScore(IQuestion question, IAnswers answers)
        {
            if (question.AnswersType != answers.GetType())
                throw new ArgumentException("The answer type must match to the question type");

            return question.AnswerKeys[0].AnswerKey == answers[0] ? question.Score : 0f;
        }
    }
}
