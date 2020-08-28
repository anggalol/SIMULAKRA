using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSELib.AnswerBox
{
    public class AnswerBoxCollection : SortedList<int, IAnswerBox>
    {
        public AnswerBoxCollection()
            : base()
        {
        }

        public new void Add(int id, IAnswerBox answerBox)
        {
            base.Add(id, answerBox);
        }
    }
}
