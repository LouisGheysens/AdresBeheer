using Adresbeheer_klassen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresbeheer_klassen
{
    public class AdresLocatie
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Id { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        /// <summary>
        /// Exceptions
        /// </summary>
        public AdresLocatie(string id, string x, string y)
        {
            if (id == null || string.IsNullOrEmpty(id.Trim()) || int.Parse(id) < 1) throw new LocatieException("Verkeerde id");
            if (x == null || string.IsNullOrEmpty(x.Trim()) || double.Parse(x) < 22000 || double.Parse(x) > 258000) throw new LocatieException("Verkeerde x");
            if (y == null || string.IsNullOrEmpty(y.Trim()) || double.Parse(y) < 152000 || double.Parse(y) > 244000) throw new LocatieException("Verkeerde y");

            Id = int.Parse(id);
            X = double.Parse(x);
            Y = double.Parse(y);
        }
        /// <summary>
        /// Hashcode genereren
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AdresLocatie locatie &&
                   Id == locatie.Id &&
                   X == locatie.X &&
                   Y == locatie.Y;
        }

        /// <summary>
        /// Hashcode opvragen
        /// </summary>

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, X, Y);
        }
    }
}
