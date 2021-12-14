using Adresbeheer_klassen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresbeheer_klassen
{
    public class Straat
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Id { get; set; }

        public string Naam { get; set; }

        public int NISCODE { get; set; }
        /// <summary>
        /// Exceptions
        /// </summary>
        public Straat(string id, string naam, string niscode)
        {
            if ( id == null) throw new StraatException("Verkeerde id");
            if (naam == null || string.IsNullOrEmpty(naam.Trim()) || naam.Length <= 0) throw new StraatException("Verkeerde naam");
            if (niscode == null || string.IsNullOrEmpty(niscode.Trim()) || niscode.Length != 5 || niscode.ToCharArray()[0] == '0') throw new StraatException("Verkeerde NISCODE");
            Id = int.Parse(id);
            Naam = naam;
            NISCODE = int.Parse(niscode);
        }
        /// <summary>
        /// Hashcode genereren
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Straat straat &&
                   Id == straat.Id &&
                   Naam == straat.Naam &&
                   NISCODE == straat.NISCODE;
        }

        /// <summary>
        /// Hashcode opvragen
        /// </summary>

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Naam, NISCODE);
        }


    }
}
