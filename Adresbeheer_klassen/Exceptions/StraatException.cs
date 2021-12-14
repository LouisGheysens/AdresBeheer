using System;
using System.Text;

namespace Adresbeheer_klassen.Exceptions
{
    public class StraatException: Exception
    {
        /// <summary>
        /// Exception toekennen aan straat
        /// </summary>
        public StraatException(string msg) : base(msg) { }

        public StraatException(string msg, Exception exception): base(msg, exception) { }
    }
}
