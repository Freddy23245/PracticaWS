using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class Conexion
    {
        public static SqlConnection ObtenerConexionSQL()
        {
            string _conString = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;
            return new SqlConnection(_conString);
        }
    }
}
