using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Compression;

namespace Adresbeheer_klassen
{
    public class DataReader
    {
        /// <summary>
        /// File toekennen aan de klasse
        /// </summary>
        static readonly string path = @"C:\tmc\extract\CRAB_Adressenlijst_GML\GML\CrabAdr.gml";

        /// <summary>
        /// Verschillende collections aanmaken
        /// </summary>
        public HashSet<Gemeente> gemeentes = new HashSet<Gemeente>();
        public HashSet<Straat> straten = new HashSet<Straat>();
        public HashSet<AdresLocatie> adreslocatie = new HashSet<AdresLocatie>();
        public HashSet<Adres> adres = new HashSet<Adres>();

        /// <summary>
        /// Methode aanmaken die de file leest
        /// </summary>
        public void readFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("agiv:CrabAdr"))
                    {
                        string[] adresgegevens = new string[16];
                        /*
                         0 is ID
                         1 is STRAATNMID
                         2 is STRAAT
                         3 is HUISNR
                         4 is APPNR                  
                         5 is BUSNR
                         6 is HNRLABEL
                         7 is NISCODE
                         8 is GEMEENTE
                         9 is POSTCODE
                         14 is X
                         15 is Y
                         */
                        for (int i = 0; i < 20; i++)
                        {
                            line = sr.ReadLine();
                            if (line.Contains("agiv:ID")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:STRAATNMID")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:STRAATNM")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:HUISNR")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:APPTNR")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:BUSNR")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:HNRLABEL")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:NISCODE")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:GEMEENTE")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("agiv:POSTCODE")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("gml:X")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                            if (line.Contains("gml:Y")) { adresgegevens[i] = Regex.Match(line, "(?<=>)(.*)(?=<)").ToString(); }
                        }
                        /// <summary>
                        /// Gelogde gegevens via de constructor
                        /// </summary>
                        if (char.IsNumber(adresgegevens[3].ElementAt(0)))
                        {
                            straten.Add(new Straat((adresgegevens[0]), adresgegevens[2], adresgegevens[7]));
                            gemeentes.Add(new Gemeente(adresgegevens[8], adresgegevens[7]));
                            adreslocatie.Add(new AdresLocatie(adresgegevens[0], adresgegevens[14], adresgegevens[15]));
                            adres.Add(new Adres(adresgegevens[0], adresgegevens[1], adresgegevens[3], adresgegevens[5], adresgegevens[4], adresgegevens[6], adresgegevens[9], adresgegevens[0]));
                        }
                        else
                        {
                            Console.WriteLine("Gelogd adres");
                            Console.WriteLine("Fout");
                            Console.WriteLine("---------------");
                            Console.WriteLine("Straat {0},", adresgegevens[2]);
                            Console.WriteLine("Huisnummer {0},", adresgegevens[3]);
                            Console.WriteLine("Gemeente: {0}", adresgegevens[8]);
                            Console.WriteLine("Postcode {0}", adresgegevens[9]);
                            Console.WriteLine("NIScode {0]", adresgegevens[7]);
                            Console.WriteLine("X", adresgegevens[14]);
                            Console.WriteLine("Y", adresgegevens[15]);
                        }
                    }
                }
            }
        }

        private void addStraat(string id, string naam, string NISCODE)
        {
            straten.Add(new Straat(id, naam, NISCODE));
        }

        private void addGemeente(string naam, string niscode)
        {
            gemeentes.Add(new Gemeente(naam, niscode));

        }

        private void addLocatie(string id, string x, string y)
        {
            adreslocatie.Add(new AdresLocatie(id, x, y));
        }

        private void addAdres(string id, string huisnummer, string huisnummerlabel, string appnummer, string busnummer, string adreslocatieid, string postcode, string straatid)
        {
            adres.Add(new Adres(id, huisnummer, huisnummerlabel, appnummer, busnummer, adreslocatieid, postcode, straatid));
        }
    }
}

