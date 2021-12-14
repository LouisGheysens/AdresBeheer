using System;
using AdresBeheer_DAL;
using Adresbeheer_klassen;
namespace AdresBeheer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Program code
            Console.WriteLine(DateTime.Now);
            /// <summary>
            /// Connectionstring
            /// </summary>
            SQLQueries sql = new SQLQueries(@"Data Source=DESKTOP-3CJB43N\SQLEXPRESS;Initial Catalog=Adressen;Integrated Security=True;Pooling=False");
            /// <summary>
            /// Object aanmaken die de file volledig leest
            /// </summary>
            //DataReader dr = new DataReader();
            //dr.readFile();
            /// <summary>
            /// Bulk copy instellen
            /// </summary>
            Console.WriteLine("Read bulk");

            Console.WriteLine("End bulk");
            //Console.WriteLine("End bulk");
            //Console.WriteLine(DateTime.Now);
            /// <summary>
            /// Toevoegen van data aan de databank
            /// </summary>
            //Console.WriteLine("Lengte gemeente " + dr.gemeentes.Count());
            //sql.BulkGemeente(dr.gemeentes);

            //Console.WriteLine("Lengte straten " + dr.straten.Count());
            //sql.BulkStraten(dr.straten);

            //Console.WriteLine("Lengte adreslocatie " + dr.adreslocatie.Count());
            //sql.BulkAdresLocatie(dr.adreslocatie);

            //Console.WriteLine("Lengte adres " + dr.adres.Count());
            //sql.BulkAdres(dr.adres);


            /// <summary>
            /// Object aanmaken die de SQL test
            /// </summary>
            #region queries
            AdressenBeheer apt = new AdressenBeheer();
            //apt.VoegGemeenteToe(new Gemeente("Lis", "09320"));
            //apt.VerwijderGemeente(09320);
            //apt.VoegStraatToe(new Straat("1121232", "Louis", "11001"));
            //apt.VerwijderStraat(1121232);
            //apt.VoegAdresToe(new Adres
            //(
            //    "23",
            //    "29299",
            //    "3",
            //     "",
            //    "",
            //    "3",
            //   "9870",
            //    "1000320926"
            //));
            //apt.VerwijderAdres(23);
            //Console.WriteLine(apt.BestaatStraatnaam("Brouwershoek", new Gemeente("Zulte", "44081"));
            //Console.WriteLine(apt.BestaatGemeente(new Gemeente("Zulte", "37010")));
            //Console.WriteLine(apt.BestaatAdres(new Adres("1", "12", "34", "", "", "A12", "9870", "124")))
            ////Straat straat = apt.SelecteerStraat(1121232);
            ////Console.WriteLine(straat.Naam);
            //Gemeente gemeente = apt.SelecteerGemeente(12005);
            //Console.WriteLine(gemeente.Naam);
            //List<Straat> straten = apt.SelecteerDeStratenInGemeente("Brugge");
            //if (straten != null)
            //{
            //    Console.WriteLine("Selecteerde straat: " + straten.Count());
            //}
            //List<Straat> tweedelijststraten = apt.SelecteerStratenInGemeente(11009);
            //if (tweedelijststraten != null)
            //{
            //    Console.WriteLine("Straten " + tweedelijststraten.Count());
            //}
            //List<Straat> straten = apt.SelecteerStratenInGemeente(37010);
            //if (straten != null)
            //{
            //    Console.WriteLine("Selecteerde straten " + straten.Count());
            //}
            //List<Gemeente> gem = apt.SelecteerGemeenten();
            //if (gem != null)
            //{
            //    Console.WriteLine("Aantal " + gem.Count());
            //}
            //Adres adres = apt.SelecteerAdres(1000320926);
            //List<Adres> adressenZulte = apt.SelecteerAdressenInGemeente(44081);
            //if (adressenZulte.Count > 0)
            //{
            //    Console.WriteLine("Voltooid, {0}", adressenZulte.Count());
            //}
            //List<Adres> adressenstraatZulte = apt.SelecteerAdressenInStraat(2); //Nog bekijken
            //if (adressenstraatZulte.Count > 0)
            //{
            //    Console.WriteLine("Voltooid, ", adressenstraatZulte.Count());
            //}
            #endregion
            #endregion


        }
    }
}
