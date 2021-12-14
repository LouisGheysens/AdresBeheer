using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdresBeheer_DAL
{
    public static class DbConfig
    {
        /// <summary>
        /// Puur extra tool voor de databank
        /// </summary>
        #region Properties
        private static SqlConnection _sqlConnection = null;

        public static SqlConnection Connection { get { if (_sqlConnection == null) { _sqlConnection = CreateConnection(); } return _sqlConnection; } }
        #endregion
        /// <summary>
        /// Handige formule voor de sql connectie
        /// </summary>
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=StoreDb;Integrated Security=True");
        }
    }
}
