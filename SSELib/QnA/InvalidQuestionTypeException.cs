using System;
using System.Runtime.Serialization;

namespace SSELib.QnA
{
    [Serializable]
    public class InvalidQuestionTypeException : Exception
    {
        private const string DEFAULT_MESSAGE = @"The question type is invalid for current simulation state.";

        public InvalidQuestionTypeException()
            : this(DEFAULT_MESSAGE)
        {
        }

        public InvalidQuestionTypeException(string message)
            : base(message)
        {
        }

        public InvalidQuestionTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidQuestionTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
