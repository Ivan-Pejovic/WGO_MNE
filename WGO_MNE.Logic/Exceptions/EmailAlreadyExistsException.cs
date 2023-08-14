using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Exceptions
{
    public class EmailAlreadyExistsException : Exception
    {
        public EmailAlreadyExistsException() { }
        public EmailAlreadyExistsException(string message) : base(message) { }
        public EmailAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
