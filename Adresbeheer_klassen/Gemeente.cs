using Adresbeheer_klassen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adresbeheer_klassen
{
    public class Gemeente
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string Naam { get; set; }

        public int NIScode { get; set; }

        /// <summary>
        /// Exceptions
        /// </summary>
        public Gemeente(string naam, string niscode)
        {
            if (string.IsNullOrEmpty(naam.Trim())) throw new GemeenteException("Gemeente naam is leeg");
            if (string.IsNullOrEmpty(naam.Trim()) || naam.Length <= 0) throw new GemeenteException("Verkeerde naam");
            if (!char.IsUpper(naam.ToCharArray()[0])) throw new GemeenteException("Naam moet met hoofdletter beginnen");
            if (string.IsNullOrEmpty(niscode.Trim())) throw new GemeenteException("Verkeerde NISCODE");
            Naam = naam;
            NIScode = int.Parse(niscode);
        }
        /// <summary>
        /// Hashcode genereren
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Gemeente gemeente &&
                   Naam == gemeente.Naam &&
                   NIScode == gemeente.NIScode;
        }

        /// <summary>
        /// Hashcode opvragen
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(Naam, NIScode);
        }
    }
}
