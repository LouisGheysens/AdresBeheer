using System;
using System.Text;

namespace Adresbeheer_klassen.Exceptions
{
    public class AdresException: Exception
    {
        /// <summary>
        /// Exception toekennen aan adres
        /// </summary>
        public AdresException(string msg): base(msg) { }
        public AdresException(string msg, Exception exception): base(msg, exception) { }
    }
}
