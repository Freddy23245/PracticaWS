using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Services;

namespace PracticaWS
{
    /// <summary>
    /// Descripción breve de PracticaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class PracticaWS : System.Web.Services.WebService
    {

        [WebMethod]
      public List<Personas> ObtenerPersonas(string ApellidoYNombre)
        {
            try
            {
                return NuevoNegocio.ObtenerPersonas(ApellidoYNombre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public List<Zonas> ObtenerZonas()
        {
            try
            {
                return NuevoNegocio.ObtenerZonas();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [WebMethod]
        public Personas RegistrarPersonas(Personas nueva)
        {
            try
            {
                return NuevoNegocio.RegistrarPersonas(nueva);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [WebMethod]
        public Personas ModificarPersonas(Personas modifica)
        {
            try
            {
                return NuevoNegocio.ModificarPersonas(modifica);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [WebMethod]
        public Personas EliminarPersonas(Personas elimina)
        {
            try
            {
                return NuevoNegocio.EliminaPersonas(elimina);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [WebMethod]
        public Zonas RegistrarZonas(Zonas nueva)
        {
            try
            {
                return ZonasNegocio.RegistrarZonas(nueva);
            }
            catch (Exception)
            {
                //falta log4net
                throw;
            }
        }
        [WebMethod]
        public Zonas ModificarZonas(Zonas modifica)
        {
            try
            {
                return ZonasNegocio.ModificarZonas(modifica);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [WebMethod]
        public Zonas EliminarZonas(Zonas elimina)
        {
            try
            {
                return ZonasNegocio.EliminarZonas(elimina);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
