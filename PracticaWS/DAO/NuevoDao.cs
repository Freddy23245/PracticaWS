using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NuevoDao
    {
        public static List<Personas> ObtenerPersonas(string ApellidoYNombre = null)
        {
			try
			{
				var con = Conexion.ObtenerConexionSQL();
				string comando = "ObtenerPersonas";
				SqlCommand cmd = new SqlCommand(comando, con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				if (string.IsNullOrEmpty(ApellidoYNombre))
					ApellidoYNombre = null;
				cmd.Parameters.AddWithValue("@ApellidoYNombre", ApellidoYNombre);
                con.Open();
                var persona = new List<Personas>();

				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						persona.Add(new Personas
						{
							id = int.Parse(dr["id"].ToString()),
                            Cuil = (dr["Cuil"].ToString()),
							ApellidoYNombre = dr["ApellidoYNombre"].ToString(),
							FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString()),
                            idZona = int.Parse(dr["idzona"].ToString()),
                            Zona = dr["zona"].ToString()
						});
					}
				}
				return persona;
			}
			catch (Exception)
			{

				throw;
			}
        }
        public static List<Zonas> ObtenerZonas()
        {
            try
            {
                var con = Conexion.ObtenerConexionSQL();
                string comando = "ObtenerZonas";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //if (string.IsNullOrEmpty(ApellidoYNombre))
                //    ApellidoYNombre = null;
                //cmd.Parameters.AddWithValue("@ApellidoYNombre", ApellidoYNombre);
                con.Open();
                var Zona = new List<Zonas>();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Zona.Add(new Zonas
                        {
                            idzona = int.Parse(dr["idzona"].ToString()),
                            zona = dr["zona"].ToString()
                        });
                    }
                }
                return Zona;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Personas RegistroPersonas(Personas nueva)
		{
			try
			{
				var con = Conexion.ObtenerConexionSQL();
				string comando = "RegistroPersonas";
				SqlCommand cmd = new SqlCommand(comando, con);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cuil", nueva.Cuil);
                cmd.Parameters.AddWithValue("@ApellidoYNombre", nueva.ApellidoYNombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", nueva.FechaNacimiento);
                cmd.Parameters.AddWithValue("@idzona", nueva.idZona);
                con.Open();
                cmd.ExecuteNonQuery();

                return nueva;
            }
			catch (Exception)
			{

				throw;
			}
		}
        public static Personas ModificarPersona(Personas modifica)
        {
            try
            {
                var con = Conexion.ObtenerConexionSQL();
                string comando = "ModificarPersonas";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", modifica.id);
                cmd.Parameters.AddWithValue("@cuil", modifica.Cuil);
                cmd.Parameters.AddWithValue("@ApellidoYNombre", modifica.ApellidoYNombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", modifica.FechaNacimiento);
                cmd.Parameters.AddWithValue("@idzona", modifica.idZona);
                con.Open();
                cmd.ExecuteNonQuery();

                return modifica;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Personas EliminarPersona(Personas elimina)
        {
            try
            {
                var con = Conexion.ObtenerConexionSQL();
                string comando = "EliminarPersonas";
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", elimina.id);
      
                con.Open();
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
