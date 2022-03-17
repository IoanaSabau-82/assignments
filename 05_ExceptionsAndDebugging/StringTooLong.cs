using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _05_ExceptionsAndDebugging
{
    [Serializable]
    internal class StringTooLong:Exception
    {
        public StringTooLong() 
        { 
        
        }

        public StringTooLong(string message) : base(message) 
        { 
        
        }

        public StringTooLong(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected StringTooLong(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
