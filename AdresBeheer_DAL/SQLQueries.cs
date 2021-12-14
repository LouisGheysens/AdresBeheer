using System;
using System.Collections.Generic;
using System.Text;
using Adresbeheer_klassen;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdresBeheer_DAL
{
    public class SQLQueries
    {

        #region Properties
        public string ConnectionString { get; private set; }
        #endregion
        #region Constructor
        public SQLQueries(string connectionstring)
        {
            ConnectionString = connectionstring;
        }
        #endregion
        /// <summary>
        /// Aanmkanen van een bulkcopy die de data verstuurd
        /// </summary>
        #region Methods 
        public void BulkGemeente(HashSet<Gemeente> gemeentes)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlBulkCopy sqbc = new SqlBulkCopy(ConnectionString))
                {
                    DataTable gemeente = new DataTable("gemeente");
                    gemeente.Columns.Add(new DataColumn("NISCODE", Type.GetType("System.String")));
                    gemeente.Columns.Add(new DataColumn("gemeentenaam", Type.GetType("System.String")));

                    foreach (Gemeente g in gemeentes)
                    {
                        gemeente.Rows.Add(g.NIScode, g.Naam);
                    }

                    sqbc.DestinationTableName = "gemeente";
                    sqbc.WriteToServer(gemeente);
                }
            }
        }

        public void BulkStraten(HashSet<Straat> straten)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlBulkCopy sqbc = new SqlBulkCopy(ConnectionString))
                {
                    DataTable straat = new DataTable("straat");
                    straat.Columns.Add(new DataColumn("id", Type.GetType("System.Int32")));
                    straat.Columns.Add(new DataColumn("straatnaam", Type.GetType("System.String")));
                    straat.Columns.Add(new DataColumn("NISCODE", Type.GetType("System.Int32")));

                    foreach (Straat s in straten)
                    {
                        straat.Rows.Add(s.Id, s.Naam, s.NISCODE);
                    }

                    sqbc.DestinationTableName = "straat";
                    sqbc.WriteToServer(straat);
                }
            }
        }

        public void BulkAdresLocatie(HashSet<AdresLocatie> adreslocatie)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlBulkCopy sqbc = new SqlBulkCopy(ConnectionString))
                {
                    DataTable adreslocaties = new DataTable("adreslocatie");
                    adreslocaties.Columns.Add(new DataColumn("id", Type.GetType("System.Int32")));
                    adreslocaties.Columns.Add(new DataColumn("x", Type.GetType("System.Decimal")));
                    adreslocaties.Columns.Add(new DataColumn("y", Type.GetType("System.Decimal")));

                    foreach (AdresLocatie adr in adreslocatie)
                    {
                       adreslocaties.Rows.Add(adr.Id, adr.X, adr.Y);
                    }

                    sqbc.DestinationTableName = "adreslocatie";
                    sqbc.WriteToServer(adreslocaties);
                }
            }
        }

        public void BulkAdres(HashSet<Adres> adressen)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlBulkCopy sqbc = new SqlBulkCopy(ConnectionString))
                {
                    DataTable adres = new DataTable("adres");
                    adres.Columns.Add(new DataColumn("id", Type.GetType("System.Int32")));
                    adres.Columns.Add(new DataColumn("straatID", Type.GetType("System.Int32")));
                    adres.Columns.Add(new DataColumn("huisnummer", Type.GetType("System.String")));
                    adres.Columns.Add(new DataColumn("appartementnummer", Type.GetType("System.String")));
                    adres.Columns.Add(new DataColumn("busnummer", Type.GetType("System.String")));
                    adres.Columns.Add(new DataColumn("huisnummerlabel", Type.GetType("System.String")));
                    adres.Columns.Add(new DataColumn("adreslocatieId", Type.GetType("System.Int32")));
                    adres.Columns.Add(new DataColumn("postcode", Type.GetType("System.Int32")));


                    foreach (Adres ad in adressen)
                    {
                        adres.Rows.Add(ad.ID, ad.StraatId, ad.HuisNummer, ad.AppNummer, ad.Busnummer, ad.HuisNummerLabel, ad.AdreslocatieId, ad.Postcode);
                    }

                    sqbc.DestinationTableName = "adres";
                    sqbc.WriteToServer(adres);
                }
            }
        }
        #endregion

    }
}


