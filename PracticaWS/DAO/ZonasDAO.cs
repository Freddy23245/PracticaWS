using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ZonasDAO
    {

        public static Zonas RegistrarZonas(Zonas nueva)
        {
			try
			{
				var con = Conexion.ObtenerConexionSQL();
				string comando = "RegistrarZona";
				SqlCommand cmd = new SqlCommand(comando, con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@zona", nueva.zona);
				con.Open();
				cmd.ExecuteNonQuery();

				return nueva;
			}
			catch (Exception)
			{

				throw;
			}
        }

		public static Zonas ModificarZonas(Zonas modifica)
		{
			try
			{
				var con = Conexion.ObtenerConexionSQL();
				string comando = "";
				SqlCommand cmd = new SqlCommand(comando,con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@idzona", modifica.idzona);
				cmd.Parameters.AddWithValue("@zona", modifica.zona);
				con.Open();
				cmd.ExecuteNonQuery();
				return modifica;
			}
			catch (Exception)
			{

				throw;
			}
		}
		public static Zonas EliminarZonas(Zonas elimina)
		{
			try
			{
				var con = Conexion.ObtenerConexionSQL();
				string comando = "";
				SqlCommand cmd = new SqlCommand(comando, con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@idzona", elimina.idzona);
				con.Open() ;
				cmd.ExecuteNonQuery();
				return elimina;
			}
			catch (Exception)
			{

				throw;
			}
		}

    }
}
