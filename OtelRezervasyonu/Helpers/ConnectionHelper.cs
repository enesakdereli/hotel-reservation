using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu.Helpers
{
    class ConnectionHelper
    {

        private static SqlConnection _cnn;
        public static SqlConnection Cnn
        {
            get
            {
                if (_cnn == null)
                {
                    _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["OtelRezervasyonDBEntities"].ConnectionString);
                }
                return _cnn;
            }
        }
    }
}
