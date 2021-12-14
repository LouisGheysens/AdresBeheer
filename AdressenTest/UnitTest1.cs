using System;
using Xunit;
using Adresbeheer_klassen;
using System.Linq;
using Adresbeheer_klassen.Exceptions;

namespace AdressenTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testcode adreslocatie
        /// </summary> 
        [Theory]
        [InlineData("", "23009", "25468")]
        [InlineData(" ", "23009", "25468")]
        [InlineData(null, "23009", "25468")]
        public void AddingWrongId(string id, string x, string y)
        {
            AdresLocatie adresl;
            var exc = Assert.Throws<LocatieException>(() => adresl = new AdresLocatie(id, x, y));
            Assert.Equal("Verkeerde id", exc.Message);
        }

        [Theory]
        [InlineData("1", "", "25468")]
        [InlineData("1", " ", "25468")]
        [InlineData("1", null, "25468")]
        [InlineData("1", "0000", "25468")]
        public void AddingWrongX(string id, string x, string y)
        {
            AdresLocatie adresl;
            var exc = Assert.Throws<LocatieException>(() => adresl = new AdresLocatie(id, x, y));
            Assert.Equal("Verkeerde x", exc.Message);
        }

        [Theory]
        [InlineData("1", "25468", "")]
        [InlineData("1", "25468", " ")]
        [InlineData("1", "25468", null)]
        [InlineData("1", "25468", "999999")]
        public void AddingWrongY(string id, string x, string y)
        {
            AdresLocatie adresl;
            var exc = Assert.Throws<LocatieException>(() => adresl = new AdresLocatie(id, x, y));
            Assert.Equal("Verkeerde y", exc.Message);
        }

        /// <summary>
        /// Testcode gemeente
        /// </summary>
        [Theory]
        [InlineData(null, "02345")]
        [InlineData("", "02345")]
        [InlineData(" ", "02345")]
        public void addWrongNameGemeente(string naam, string niscode)
        {
            Gemeente g;
            var exc = Assert.Throws<GemeenteException>(() => g = new Gemeente(naam, niscode));
            Assert.Equal("Verkeerde naam", exc.Message);
        }

        [Theory]
        [InlineData("Deinze", null)]
        [InlineData("Zulte", "")]
        [InlineData("Waregem", "012345")]
        public void WrongNISCODEGemeente(string naam, string niscode)
        {
            Gemeente g;
            var exc = Assert.Throws<GemeenteException>(() => g = new Gemeente(naam, niscode));
            Assert.Equal("Verkeerde NISCODE", exc.Message);
        }

        /// <summary>
        /// Testcode straat
        /// </summary>
        [Theory]
        [InlineData("", "Peter", "23009")]
        [InlineData(" ", "Fruut", "23009")]
        public void addWrongIDStraat(string id, string naam, string NISCODE)
        {
            Straat s;
            var exc = Assert.Throws<StraatException>(() => s = new Straat(id, naam, NISCODE));
            Assert.Equal("Verkeerde id", exc.Message);
        }

        [Theory]
        [InlineData("1", "", "23009")]
        [InlineData("1", " ", "23009")]
        [InlineData("1", null, "23009")]
        public void addWrongNameStraat(string id, string naam, string NISCODE)
        {
            Straat s;
            var exc = Assert.Throws<StraatException>(() => s = new Straat(id, naam, NISCODE));
            Assert.Equal("Verkeerde naam", exc.Message);
        }

        [Theory]
        [InlineData("1", "Peter", "012345")]
        [InlineData("1", "Fruut", " ")]
        [InlineData("1", "Flar", null)]
        public void addWrongNISCODEStraat(string id, string naam, string NISCODE)
        {
            Straat s;
            var exc = Assert.Throws<StraatException>(() => s = new Straat(id, naam, NISCODE));
            Assert.Equal("Verkeerde NISCODE", exc.Message);
        }

        /// <summary>
        /// Testcode adres
        /// </summary>
        [Theory]
        [InlineData("", "2", "2", "1", "10", "A12", "9870", "12")]
        [InlineData(" ", "3", "3", "2", "9", "A13", "1200", "11")]
        [InlineData(null, "5", "4", "3", "8", "A14", "1111", "10")]
        public void addWrongIdAdres(string id, string straatid, string huisnummer, string busnummer, string appnummer, string huisnummerlabel, string postcode, string adreslocatieid)
        {
            Adres a;
            var exc = Assert.Throws<AdresException>(() => a = new Adres(id, straatid, huisnummer, busnummer, appnummer, huisnummerlabel, postcode, adreslocatieid));
            Assert.Equal("Verkeerde id", exc.Message);
        }

        [Theory]
        [InlineData("1", "", "2", "1", "10", "A12", "9870", "12")]
        [InlineData("2", " ", "3", "2", "9", "A13", "1200", "11")]
        [InlineData("3", null, "4", "3", "8", "A14", "1111", "10")]
        public void addWrongStraatidIdAdres(string id, string straatid, string huisnummer, string busnummer, string appnummer, string huisnummerlabel, string postcode, string adreslocatieid)
        {
            Adres a;
            var exc = Assert.Throws<AdresException>(() => a = new Adres(id, straatid, huisnummer, busnummer, appnummer, huisnummerlabel, postcode, adreslocatieid));
            Assert.Equal("Verkeerde straatid", exc.Message);
        }

        [Theory]
        [InlineData("1", "2", " ", "1", "10", "A12", "9870", "12")]
        [InlineData("2", "3", "", "2", "9", "A13", "1200", "11")]
        [InlineData("3", "5", null, "3", "8", "A14", "1111", "10")]
        public void addWrongHuisnummerdAdres(string id, string straatid, string huisnummer, string busnummer, string appnummer, string huisnummerlabel, string postcode, string adreslocatieid)
        {
            Adres a;
            var exc = Assert.Throws<AdresException>(() => a = new Adres(id, straatid, huisnummer, busnummer, appnummer, huisnummerlabel, postcode, adreslocatieid));
            Assert.Equal("Verkeerd huisnummer", exc.Message);
        }

        [Theory]
        [InlineData("1", "2", "3", "1", "10", "A12", " ", "9870")]
        [InlineData("2", "3", "23", "2", "9", "A13", "", "1200")]
        [InlineData("3", "5", "24", "3", "8", "A14", null, "1111")]
        public void addWrongPostcodeAdres(string id, string straatid, string huisnummer, string busnummer, string appnummer, string huisnummerlabel, string postcode, string adreslocatieid)
        {
            Adres a;
            var exc = Assert.Throws<AdresException>(() => a = new Adres(id, straatid, huisnummer, busnummer, appnummer, huisnummerlabel, postcode, adreslocatieid));
            Assert.Equal("Verkeerde postcode", exc.Message);
        }







    }
}
