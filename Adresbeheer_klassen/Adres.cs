using Adresbeheer_klassen.Exceptions;
using System;
using System.Text;

namespace Adresbeheer_klassen
{
    public class Adres
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int ID { get; set; }

        public int StraatId { get; set; }

        public string HuisNummer { get; set; }

        public string Busnummer { get; set; }

        public string AppNummer { get; set; }

        public string HuisNummerLabel { get; set; }

        //Gemeente zit reeds in straat

        public int AdreslocatieId { get; set; }

        public int Postcode { get; set; }

        public string Straat { get; set; }

        /// <summary>
        /// Exceptions
        /// </summary>
        public Adres(string id, string straatid, string huisnummer, string busnummer, string appnummer, string huisnummerlabel, string postcode, string adreslocatieid)
        {
            if (id == null || string.IsNullOrEmpty(id.Trim()) || int.Parse(id) < 1) throw new AdresException("Verkeerde id");
            if (straatid == null || string.IsNullOrEmpty(straatid.Trim()) || int.Parse(straatid) < 1) throw new AdresException("Verkeerde straatid");
            if (huisnummer == null || string.IsNullOrEmpty(huisnummer.Trim()) || !char.IsDigit(huisnummer.ToCharArray()[0])) throw new AdresException("Verkeerd huisnummer");
            if (postcode == null || string.IsNullOrEmpty(postcode.Trim()) || postcode.Length != 4) throw new AdresException("Verkeerde postcode");

            ID = int.Parse(id);
            StraatId = int.Parse(straatid);
            HuisNummer = huisnummer;
            Busnummer = busnummer;
            AppNummer = appnummer;
            HuisNummerLabel = huisnummerlabel;
            Postcode = int.Parse(postcode);
            AdreslocatieId = int.Parse(adreslocatieid);
        }

        /// <summary>
        /// Hashcode genereren
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Adres adres &&
                   ID == adres.ID &&
                   StraatId == adres.StraatId &&
                   HuisNummer == adres.HuisNummer &&
                   Busnummer == adres.Busnummer &&
                   AppNummer == adres.AppNummer &&
                   HuisNummerLabel == adres.HuisNummerLabel &&
                   AdreslocatieId == adres.AdreslocatieId &&
                   Postcode == adres.Postcode;
        }

        /// <summary>
        /// Hashcode opvragen
        /// </summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, StraatId, HuisNummer, Busnummer, AppNummer, HuisNummerLabel, AdreslocatieId, Postcode);
        }
    }
}
