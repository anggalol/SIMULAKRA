using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace SSELib.QnA.AnswerBox
{
    public class AnswerBoxUserControl : MetroUserControl
    {
        public event EventHandler<AnswersChangedEventArgs> AnswersChanged;
        protected virtual void OnAnswersChanged(AnswersChangedEventArgs e)
        {
            AnswersChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Tingkat perbesaran elemen-elemen yang berada pada jangkauan kontrol <see cref="AnswerBoxUserControl"/>.
        /// </summary>
        [Category("Answer Box Appearance")]
        [DefaultValue(AnswerBoxElementSize.Standard)]
        public virtual AnswerBoxElementSize AnswerBoxElementSize { get; set; }

        public virtual void UpdateOptions(string[,] optionsText)
        {
            throw new NotImplementedException();
        }
    }
}
