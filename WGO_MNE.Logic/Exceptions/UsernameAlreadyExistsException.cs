using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Exceptions
{
    public class UsernameAlreadyExistsException : Exception
    {
        public UsernameAlreadyExistsException() { }
        public UsernameAlreadyExistsException(string message) : base(message) { }
        public UsernameAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
