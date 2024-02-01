using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsEnzo
{
    internal class ComputerSaysNoException : Exception
    {
        // eerste no args
        public ComputerSaysNoException(): base() { }

        // tweede message
        public ComputerSaysNoException(string message) : base(message) { }

        // derde message + andere exception 
        public ComputerSaysNoException(string message, Exception e) : base(message, e)
        {

        }

    }
}
