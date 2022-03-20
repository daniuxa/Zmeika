using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    public class SizeException : Exception
    {
        public int Value { get; }

        public SizeException(int Value, string Msg) : base(Msg)
        {
            this.Value = Value;
        }
    }
}
