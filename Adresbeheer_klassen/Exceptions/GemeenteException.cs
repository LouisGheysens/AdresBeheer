using System;
using System.Text;

namespace Adresbeheer_klassen.Exceptions
{
   public class GemeenteException: Exception
   {
        /// <summary>
        /// Exception toekennen aan gemeente
        /// </summary>
        public GemeenteException(string msg) : base(msg) { }
        public GemeenteException(string msg, Exception exception) : base(msg, exception) { }
   }
}
