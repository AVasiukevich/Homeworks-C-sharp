using System;
using System.Runtime.Serialization;

namespace AirplanePilotSimulator
{
    [Serializable]
    internal class AirplaneException : Exception
    {
        public AirplaneException()
        {
        }

        public AirplaneException(string message) : base(message)
        {
        }

        public AirplaneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AirplaneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}