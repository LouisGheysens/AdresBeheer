using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Adresbeheer_klassen
{
    public class AdressenBeheer : IAdresBeheer
    {
        /// <summary>
        /// Coonectionstring
        /// </summary>
        public static readonly string connectionstring = @"Data Source=DESKTOP-3CJB43N\SQLEXPRESS;Initial Catalog=Adressen;Integrated Security=True;Pooling=False";
        /// <summary>
        /// SQL queries
        /// </summary>
        public bool BestaatAdres(Adres adres)
        {
            var conn = new SqlConnection(connectionstring);
            conn.Open();
            string sql = "SELECT * FROM adres adr where adr.straatid=@straatid AND adr.huisnummer=@huisnummer AND adr.postcode=@postcode";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@straatid", adres.StraatId);
                cmd.Parameters.AddWithValue("@huisnummer", adres.HuisNummer);
                cmd.Parameters.AddWithValue("@postcode", adres.Postcode);

                conn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    Adres a = new Adres(
                        reader["id"].ToString(),
                        reader["straatid"].ToString(),
                        reader["huisnummer"].ToString(),
                        reader["busnummer"].ToString(),
                        reader["appnummer"].ToString(),
                        reader["huisnummerlabel"].ToString(),
                        reader["postcode"].ToString(),
                        reader["adreslocatieid"].ToString());
                    return a != null;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public bool BestaatGemeente(string gemeente, int niscode)
        {
            SqlConnection conn = new(connectionstring);
            string query = "SELECT COUNT(1) FROM [Adressen].[dbo].[gemeente] WHERE gemeentenaam = @gemeentenaam AND NISCODE = @niscode;";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    bool result = false;
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@niscode", SqlDbType.Int));
                    cmd.Parameters["@niscode"].Value = niscode;

                    cmd.Parameters.Add(new SqlParameter("@gemeentenaam", SqlDbType.NVarChar));
                    cmd.Parameters["@gemeentenaam"].Value = gemeente;
                    Console.WriteLine();
                    result = (int)cmd.ExecuteScalar() == 1 ? true : false;
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public bool BestaatStraatnaam(string straatnaam, int niscode)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT COUNT(1) FROM [Adressen].[dbo].[straat] WHERE straatnaam = @straatnaam AND NISCODE = @niscode;";
            using (SqlCommand cmd = conn.CreateCommand())
            { conn.Open();
                try
                {
                    bool result = false;
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@niscode", SqlDbType.Int));
                    cmd.Parameters["@niscode"].Value = niscode;

                    cmd.Parameters.Add(new SqlParameter("@straatnaam", SqlDbType.NVarChar));
                    cmd.Parameters["@straatnaam"].Value = straatnaam;
                    Console.WriteLine();
                    result = (int)cmd.ExecuteScalar() == 1 ? true : false;
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public Adres SelecteerAdres(int id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM adres WHERE id=@id";

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = query;

                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Adres adres = new Adres
                    (
                        reader["id"].ToString(),
                        reader["straatid"].ToString(),
                        reader["huisnummer"].ToString(),
                        reader["busnummer"].ToString(),
                        reader["appartementnummer"].ToString(),
                        reader["huisnummerlabel"].ToString(),
                        reader["postcode"].ToString(),
                        reader["adreslocatieid"].ToString()
                    );
                    return adres;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                finally { connection.Close(); }
            }
        }
        public List<Adres> SelecteerAdressenInGemeente(int NIScode)
        {
            List<Adres> adressenlijst = new List<Adres>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT a.id, a.straatID, a.huisnummer, a.appartementnummer, a.busnummer, a.huisnummerlabel, a.adreslocatieID, a.postcode, stra.NISCODE FROM adres a LEFT JOIN straat stra ON a.straatID = stra.id WHERE stra.NISCODE= @NISCODE";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                SqlParameter parameteradr = new SqlParameter();
                parameteradr.ParameterName = "@NISCODE";
                parameteradr.DbType = System.Data.DbType.String;
                parameteradr.Value = NIScode;
                cmd.Parameters.Add(parameteradr);

                conn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        adressenlijst.Add(new Adres
                        (
                        reader["id"].ToString(),
                        reader["straatid"].ToString(),
                        reader["huisnummer"].ToString(),
                        reader["busnummer"].ToString(),
                        reader["appartementnummer"].ToString(),
                        reader["huisnummerlabel"].ToString(),
                        reader["postcode"].ToString(),
                        reader["adreslocatieid"].ToString()
                        ));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Niet gelukt!");
                }
                finally
                {
                    conn.Close();
                }
                return adressenlijst;
            }
        }
        public List<Adres> SelecteerAdressenInStraat(int straatID)
        {
            List<Adres> adresstraatlijst = new List<Adres>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT a.id, a.straatID, a.huisnummer, a.appartementnummer, a.busnummer, a.huisnummerlabel, a.adreslocatieID, a.postcode, stra.NISCODE FROM adres a LEFT JOIN straat stra ON a.straatID = stra.id WHERE stra.id= @straatid";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                SqlParameter parameteradrstraat = new SqlParameter();
                parameteradrstraat.ParameterName = "@straatid";
                parameteradrstraat.DbType = System.Data.DbType.String;
                parameteradrstraat.Value = straatID;
                cmd.Parameters.Add(parameteradrstraat);

                conn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        adresstraatlijst.Add(new Adres
                    (
                        reader["id"].ToString(),
                        reader["straatid"].ToString(),
                        reader["huisnummer"].ToString(),
                        reader["busnummer"].ToString(),
                        reader["appartementnummer"].ToString(),
                        reader["huisnummerlabel"].ToString(),
                        reader["postcode"].ToString(),
                        reader["adreslocatieid"].ToString()
                    ));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Niet gelukt!");
                }
                finally
                {
                    conn.Close();
                }
                return adresstraatlijst;
            }
        }
        public Gemeente SelecteerGemeente(int NIScode)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM gemeente WHERE NISCODE=@NISCODE";

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = query;

                command.Parameters.AddWithValue("@NISCODE", NIScode);

                connection.Open();
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Gemeente gemeente = new Gemeente(reader["gemeentenaam"].ToString(), reader["NISCODE"].ToString());
                    return gemeente;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                finally { connection.Close(); }
            }
        }
        public List<Gemeente> SelecteerGemeenten()
        {
            List<Gemeente> gemeentes = new List<Gemeente>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT * FROM gemeente";
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = query;
                conn.Open();
                try
                {
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        gemeentes.Add(new Gemeente(r["gemeentenaam"].ToString(), r["NISCODE"].ToString()));
                    }
                    return gemeentes;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
                return null;
            }
        }
        public Straat SelecteerStraat(int id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM straat WHERE id=@Id";

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Straat straat = new Straat((string)reader["id"].ToString(), (string)reader["straatnaam"], (string)reader["NIScode"]);
                    Console.WriteLine(straat);
                    return straat;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                finally { connection.Close(); }
            }
        }
        public List<Straat> SelecteerStratenInGemeente(int NIScode)
        {
            List<Straat> gemeentemetniscode = new List<Straat>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT stra.id, stra.straatnaam, stra.NISCODE FROM straat stra LEFT JOIN gemeente gem ON stra.NISCODE = gem.NISCODE WHERE gem.NISCODE=@NISCODE";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                SqlParameter parametergemeente = new SqlParameter();
                parametergemeente.ParameterName = "@NISCODE";
                parametergemeente.DbType = System.Data.DbType.String;
                parametergemeente.Value = NIScode;
                cmd.Parameters.Add(parametergemeente);

                conn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        gemeentemetniscode.Add(new Straat((string)reader["id"].ToString(), reader["straatnaam"].ToString(), reader["NISCODE"].ToString()));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Niet gelukt!");
                }
                finally
                {
                    conn.Close();
                }
                return gemeentemetniscode;
            }
        }
        public List<Straat> SelecteerDeStratenInGemeente(string gemeentenaam)
        {
            List<Straat> stratenlijst = new List<Straat>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT stra.id, stra.straatnaam, stra.NISCODE FROM straat stra LEFT JOIN gemeente gem ON stra.NISCODE = gem.NISCODE WHERE gem.gemeentenaam=@gemeentenaam";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;

                SqlParameter parametergemeente = new SqlParameter();
                parametergemeente.ParameterName = "@gemeentenaam";
                parametergemeente.DbType = System.Data.DbType.String;
                parametergemeente.Value = gemeentenaam;
                cmd.Parameters.Add(parametergemeente);

                conn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        stratenlijst.Add(new Straat((string)reader["id"].ToString(), reader["straatnaam"].ToString(), (string)reader["NISCODE"].ToString()));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Niet gelukt!");
                }
                finally
                {
                    conn.Close();
                }
                return stratenlijst;
            }
        }
        public void UpdateAdres(Adres adres)
        {
            if (adres.ID <= 0) throw new Exception("FOUTMELDING");

            var conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = $"UPDATE adres SET straatid = '" + adres.StraatId + "', huisnummer ='" + adres.HuisNummer + "', appartementnummer ='" + adres.AppNummer
                       + "', busnummer ='" + adres.Busnummer + "', huisnummerlabel ='" + adres.HuisNummerLabel + "', adreslocatieid ='" + adres.AdreslocatieId
                       + "', postcode ='" + adres.Postcode + "' WHERE Id = " + adres.ID;
                var updateCommand = new SqlCommand(sql, conn);
                var numberOfRows = updateCommand.ExecuteNonQuery();

                if (numberOfRows != 1)
                    throw new Exception("FOUTMELDING");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Not updated");
            }
            finally
            {
                conn.Dispose();
            }
        }
        public void UpdateGemeente(Gemeente gemeente)
        {

            if (gemeente.Naam == " ") throw new Exception("FOUTMELDING");

            var conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = $"UPDATE gemeente SET gemeente = '" + gemeente.Naam + "' WHERE NISCODE = " + gemeente.NIScode;
                var updateCommand = new SqlCommand(sql, conn);
                var numberOfRows = updateCommand.ExecuteNonQuery();

                if (numberOfRows != 1)
                    throw new Exception("FOUTMELDING");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Dispose();
            }

        }
        public void UpdateStraat(Straat straat)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "UPDATE [dbo].[straat] SET[straatnaam] = @straatnaam WHERE id = @id;";
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@straatnaam", SqlDbType.NVarChar));
                    cmd.CommandText = query;
                    cmd.Parameters["@id"].Value = straat.Id;
                    cmd.Parameters["@straatnaam"].Value = straat.Naam;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e) { throw new Exception(e.Message); }
                finally { conn.Close(); }
            }
        }
        public void VerwijderAdres(int id)
        {
            var conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = $"DELETE FROM Adres WHERE Id = " + id;
                var updateCommand = new SqlCommand(sql, conn);
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void VerwijderGemeente(int NIScode)
        {
            var conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = $"DELETE FROM Gemeente WHERE NISCODE = " + NIScode;
                var updateCommand = new SqlCommand(sql, conn);
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void VerwijderStraat(int id)
        {
            var conn = new SqlConnection(connectionstring);
            try
            {
                conn.Open();
                string sql = $"DELETE FROM straat WHERE id = " + id;
                var updateCommand = new SqlCommand(sql, conn);
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void VoegAdresToe(Adres adres)
        {
            string query = "INSERT INTO adres VALUES (@id,@straatid,@huisnummer,@appnummer,@busnummer,@huisnummerlabel,@adreslocatieid,@postcode)";
            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                try
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", adres.ID);
                    cmd.Parameters.AddWithValue("@straatid", adres.StraatId);
                    cmd.Parameters.AddWithValue("@huisnummer", adres.HuisNummer);
                    cmd.Parameters.AddWithValue("@appnummer", adres.AppNummer);
                    cmd.Parameters.AddWithValue("@busnummer", adres.Busnummer);
                    cmd.Parameters.AddWithValue("@huisnummerlabel", adres.HuisNummerLabel);
                    cmd.Parameters.AddWithValue("@adreslocatieid", adres.AdreslocatieId);
                    cmd.Parameters.AddWithValue("@postcode", adres.Postcode);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Not saved...");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void VoegGemeenteToe(Gemeente gemeente)
        {
            string query = "INSERT INTO gemeente VALUES (@niscode,@gemeentenaam)";
            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                try
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@niscode", gemeente.NIScode);
                    cmd.Parameters.AddWithValue("@gemeentenaam", gemeente.Naam);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Not saved...");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void VoegStraatToe(Straat straat)
        {

            string query = "INSERT INTO straat VALUES (@id,@straatnaam,@niscode)";
            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                try
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", straat.Id);
                    cmd.Parameters.AddWithValue("@straatnaam", straat.Naam);
                    cmd.Parameters.AddWithValue("@niscode", straat.NISCODE);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Not saved...");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public List<Straat> SelecteerStraten()
        {
            List<Straat> straten = new List<Straat>();
            SqlConnection conn = new SqlConnection(connectionstring);
            string query = "SELECT * FROM straat";
            using (SqlCommand comm = conn.CreateCommand())
            {
                comm.CommandText = query;
                conn.Open();
                try
                {
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        straten.Add(new Straat((string)r["id"].ToString(), r["straatnaam"].ToString(), r["NISCODE"].ToString()));
                    }
                    return straten;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
                return null;
            }
        }
    }
}

