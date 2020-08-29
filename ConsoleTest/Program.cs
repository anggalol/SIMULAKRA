using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSELib;
using SSELib.Question;
using SSELib.AnswerKey;
using System.Xml.Serialization;
using System.IO;
using SSELib.Answer;
using SSELib.Scoring;

namespace ConsoleTest
{
    class Program
    {
        private static void Main()
        {
            // Tes kode disini
            EssayQuestion eq = new EssayQuestion();

            eq.GetAnswers().Length = 10;
            IAnswers answers = eq.GetAnswers();

            #region Notifier

            Console.Write("success");
            Console.Read();

            #endregion
        }
    }
}
