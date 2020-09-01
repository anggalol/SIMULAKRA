using System;
using SSELib.QnA.Answer;
using SSELib.QnA.Question;

namespace SSELib.QnA.Scoring
{
    [InDevelopment(Info = "The automatic scoring for this question type is still in development.")]
    public class EssayScoring : IQuestionScore
    {
        public float CalculateScore(IQuestion question, IAnswers answers)
        {
            if (question.AnswersType != answers.GetType())
                throw new ArgumentException("The answer type must match to the question type");

            int distance = CalculateDamerauLevenshteinDistance(question.AnswerKeys[0].AnswerKey, answers[0]);
            int treshold = 10;

            float percentageLoss;
            for (int i = 0; ; i++)
            {
                if (distance > treshold * i && distance < treshold * (i + 1))
                {
                    percentageLoss = (float)i / question.Score * 100;
                    break;
                }
            }

            return question.Score * (1 - percentageLoss);
        }

        // Kita gunakan jarak Damerau-Levenshtein untuk skoring soal essai.
        // Source: https://programm.top/en/c-sharp/algorithm/damerau-levenshtein-distance/

        private int Minimum(int a, int b) => a < b ? a : b;

        private int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        private int CalculateDamerauLevenshteinDistance(string firstText, string secondText)
        {
            int n = firstText.Length + 1;
            int m = secondText.Length + 1;
            int[,] arrayD = new int[n, m];

            for (int i = 0; i < n; i++)
                arrayD[i, 0] = i;

            for (int j = 0; j < m; j++)
                arrayD[0, j] = j;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    int cost = firstText[i - 1] == secondText[j - 1] ? 0 : 1;

                    arrayD[i, j] = Minimum(arrayD[i - 1, j] + 1,    // delete
                        arrayD[i, j - 1] + 1,                       // insert
                        arrayD[i - 1, j - 1] + cost);               // replacement

                    if (i > 1 && j > 1 && firstText[i - 1] == secondText[j - 2] && firstText[i - 2] == secondText[j - 1])
                    {
                        arrayD[i, j] = Minimum(arrayD[i, j],
                            arrayD[i - 2, j - 2] + cost);           // permutation
                    }
                }
            }

            return arrayD[n - 1, m - 1];
        }
    }
}
