using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSELib.QnA;
using SSELib.QnA.Question;
using SSELib.QnA.Answer;
using SSELib.QnA.AnswerBox;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleTest
{
    class Program
    {
        private static void Main()
        {
            // Tes kode disini
            AnswerKeys ak = new AnswerKeys();
            ak.Add(0, new Key("adfg"));
            ak.Add(1, new Key("aaffg"));
            ak.Add(2, new Key("adfafafg"));
            ak.Add(3, new Key("fa"));
            ak.Add(4, new Key("hodaufi "));

            MultipleAnswerQuestion maq = new MultipleAnswerQuestion
            {
                AnswerOptions = new Options(5, 1),
                AnswerKeys = ak,
                UsingAudio = true,
                OptionsText = new string[5, 1] { { "14" }, { "114" }, { "1af4" }, { "1asd a4" }, { "1fadf4" } },
                Score = 123.74f
            };

            XmlSerializer ser = new XmlSerializer(typeof(MultipleAnswerQuestion));
            TextWriter tw = new StreamWriter("D:\\finuiale.txt");
            //FileStream fs = new FileStream("D:\\finuiale.txt", FileMode.Open);
            ser.Serialize(tw, maq);
            //MultipleAnswerQuestion res = (MultipleAnswerQuestion)ser.Deserialize(fs);

            #region Notifier

            Console.Write("success");
            Console.Read();

            #endregion
        }
    }
}
