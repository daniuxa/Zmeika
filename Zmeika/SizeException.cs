using System;
using System.Runtime.Serialization;

namespace Zmeika
{
    [Serializable]
    internal class SizeException : Exception
    {
        public int Value;
        public string Msg;

        public SizeException()
        {
        }

        public SizeException(string message) : base(message)
        {

        }

        public SizeException(int Value, string Message)
        {
            this.Value = Value;
            this.Msg = Message;
        }

    }
}