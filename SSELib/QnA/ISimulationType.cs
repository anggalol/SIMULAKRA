using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSELib.QnA
{
    public interface ISimulationType
    {
        float MaxScore { get; }

        string[] AllowableQuestionTypes { get; }
    }
}
