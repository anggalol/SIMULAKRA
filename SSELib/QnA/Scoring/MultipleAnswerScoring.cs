using System;
using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public class MultipleAnswerScoring : IQuestionScore
    {
        public float CalculateScore(IQuestion question, IAnswers answers)
        {
            if (question.AnswersType != answers.GetType())
                throw new ArgumentException("The answer type must match to the question type");

            int correctAnswer = 0;
            foreach (int aid in question.AnswerKeys.IDs)
            {
                if (question.AnswerKeys[aid].AnswerKey == answers[aid])
                    correctAnswer++;
            }

            return (float)correctAnswer / question.MustAnsweredOptions * question.Score;
        }
    }
}
