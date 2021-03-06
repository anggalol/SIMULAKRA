﻿using System.Collections.Generic;
using SSELib.QnA.Question;

namespace SSELib.QnA.Answer
{
    public class AnswersCollection
    {
        private SortedList<int, IAnswers> _answersSL;

        public AnswersCollection()
        {
            _answersSL = new SortedList<int, IAnswers>();
        }

        public IList<int> IDs => _answersSL.Keys;

        public IList<IAnswers> AnswersList => _answersSL.Values;

        public int Count => _answersSL.Count;

        public IAnswers this[int id]
        {
            get => _answersSL[id];
            set => _answersSL[id] = value;
        }

        public float GetTotalScoreObtained(QuestionCollection qc)
        {
            float totalScore = 0f;
            foreach (int qid in qc.IDs)
                totalScore += _answersSL[qid].QuestionScore.CalculateScore(qc[qid], _answersSL[qid]);

            return totalScore;
        }

        public void GenerateDefaultAnswersData(QuestionCollection qc)
        {
            foreach (int questionID in qc.IDs)
            {
                IAnswers answers = (IAnswers)InstanceFactory.CreateInstance(qc[questionID].AnswersType);
                answers.IsDoubt = false;
                foreach (int answerID in qc[questionID].AnswerKeys.IDs)
                    answers.Add(answerID, answers.DefaultAnswersValue);

                _answersSL.Add(questionID, answers);
            }
        }

        public bool TryGetAnswers(int id, out IAnswers answers)
        {
            return _answersSL.TryGetValue(id, out answers);
        }

        public bool ContainsId(int id)
        {
            return _answersSL.ContainsKey(id);
        }

        public bool ContainsAnswers(IAnswers answers)
        {
            return _answersSL.ContainsValue(answers);
        }

        public int IndexOfId(int id)
        {
            return _answersSL.IndexOfKey(id);
        }

        public int IndexOfAnswers(IAnswers answers)
        {
            return _answersSL.IndexOfValue(answers);
        }
    }
}
