using System;
using System.Text;

namespace Adresbeheer_klassen.Exceptions
{
    public class LocatieException : Exception
    {
        /// <summary>
        /// Exception toekennen aan locatie
        /// </summary>
        public LocatieException(string msg) : base(msg) { }
        public LocatieException(string msg, Exception exception) : base(msg, exception) { }
    }
}
