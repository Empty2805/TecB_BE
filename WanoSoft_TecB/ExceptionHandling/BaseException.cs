using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WanoSoft_TecB.ExceptionHandling
{
    public class BaseException : System.Exception, ISerializable
    {
        public BaseException() : base()
        {
            // add implementation (if required)
        }
        public BaseException(string message) 
            : base(String.Format("Something error {0}", message))
        {
            // add implementation (if required)
        }
        public BaseException(string message, System.Exception inner)
         : base(message, inner)
        {
            // Add implementation (if required)
        }
        protected BaseException(SerializationInfo info, StreamingContext context)
         : base(info, context)
        {
            // Add implementation (if required)
        }
    }
}
