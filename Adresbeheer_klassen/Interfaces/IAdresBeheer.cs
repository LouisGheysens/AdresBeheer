using System;
using System.Collections.Generic;
using System.Text;

namespace Adresbeheer_klassen
{
    public interface IAdresBeheer
    {
        /// <summary>
        /// Interface /contract programma
        /// </summary>
        static readonly string connectionstring = @"Data Source=DESKTOP-3CJB43N\SQLEXPRESS;Initial Catalog=Adressen;Integrated Security=True;Pooling=False";
        bool BestaatAdres(Adres adres);
        bool BestaatGemeente(string gemeente, int niscode);
        bool BestaatStraatnaam(string straatnaam, int gemeente);
        Adres SelecteerAdres(int id);
        List<Adres> SelecteerAdressenInGemeente(int NIScode);
        List<Adres> SelecteerAdressenInStraat(int straatID);
        Gemeente SelecteerGemeente(int NIScode);
        List<Gemeente> SelecteerGemeenten();
        Straat SelecteerStraat(int id);
        List<Straat> SelecteerStratenInGemeente(int NIScode);
        List<Straat> SelecteerDeStratenInGemeente(string gemeentenaam);
        void UpdateAdres(Adres adres);
        void UpdateGemeente(Gemeente gemeente);
        void UpdateStraat(Straat straat);
        void VerwijderAdres(int id);
        void VerwijderGemeente(int NIScode);
        void VerwijderStraat(int id);
        void VoegAdresToe(Adres adres);
        void VoegGemeenteToe(Gemeente gemeente);
        void VoegStraatToe(Straat straat);
        List<Straat> SelecteerStraten();
        }
    }



 