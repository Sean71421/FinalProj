using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    using System;

    /// <summary>
    /// Represents errors excpetion that occur
    /// </summary>
    public class LibraryException : Exception
    {
        public LibraryException() : base() { }
        public LibraryException(string message) : base(message) { }
        public LibraryException(string message, Exception innerException) : base(message, innerException) { }
    }
}