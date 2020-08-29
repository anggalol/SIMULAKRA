using System;
using SSELib.Question;
using SSELib.Answer;

namespace SSELib.Scoring
{
    // Perbaiki
    public class MultipleChoiceScoring : IQuestionScoring
    {
        public float CalculateScore(IQuestion question, IAnswers answer)
        {
            MultipleChoiceQuestion mcq = question as MultipleChoiceQuestion;
            if (mcq.AnswerKeys.KeyCount != answer.Length)
                throw new ArgumentException("The length of the answer keys must same as the length of the answers.");

            int correct = 0;
            foreach (int id in answer.IDs)
            {
                if (mcq.AnswerKeys[id].AnswerKey == answer[id])
                    correct++;
            }

            return (float)correct / mcq.AnswerKeys.KeyCount * mcq.Score;
        }
    }
}
