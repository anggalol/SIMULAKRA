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
            Bija biji = new Bija("ememfjaif", 123);

            XmlSerializer serializer = new XmlSerializer(typeof(Bija));
            TextWriter tw = new StreamWriter("D:\\ex.txt");
            //FileStream fs = new FileStream("D:\\ex.txt", FileMode.Open);
            //Bija res = (Bija)serializer.Deserialize(fs);
            serializer.Serialize(tw, biji);

            #region Notifier

            Console.Write("success");
            Console.Read();

            #endregion
        }
    }

    public class Bija
    {
        private Bija()
        {
        }

        public Bija(string aks, int asd)
        {
            Aks = aks;
            Asd = asd;
        }

        public string AAA => Aks;

        public string Aks { get; private set; }

        public int Asd { get; private set; }
    }
}
