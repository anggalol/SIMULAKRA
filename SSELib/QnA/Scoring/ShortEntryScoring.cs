using System;
using System.Text.RegularExpressions;
using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    public class ShortEntryScoring : IQuestionScore
    {
        public float CalculateScore(IQuestion question, IAnswers answers)
        {
            if (question.AnswersType != answers.GetType())
                throw new ArgumentException("The answer type must match to the question type");

            Regex regex = question.AnswerKeys[0].KeyRegex;

            return (regex is null) ? (question.AnswerKeys[0].AnswerKey == answers[0] ? question.Score : 0f)
                : (regex.IsMatch(answers[0]) ? question.Score : 0f);
        }
    }
}
