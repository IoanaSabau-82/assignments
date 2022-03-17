using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _05_ExceptionsAndDebugging
{
    [Serializable]
    internal class StringTooShort:Exception
    {
        public StringTooShort() 
        { 
        
        }

        public StringTooShort(string message) : base(message) 
        { 
        
        }

        public StringTooShort(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected StringTooShort(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
