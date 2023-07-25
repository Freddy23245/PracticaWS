using DAO;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NuevoNegocio
    {
        public static List<Personas> ObtenerPersonas(string ApellidoYNombre)
        {
            return NuevoDao.ObtenerPersonas(ApellidoYNombre);
        }
        public static Personas RegistrarPersonas(Personas nuevo)
        {
            return NuevoDao.RegistroPersonas(nuevo);
        }
        public static Personas ModificarPersonas(Personas modifca)
        {
            return NuevoDao.ModificarPersona(modifca);
        }
        public static Personas EliminaPersonas(Personas elimina)
        {
            return NuevoDao.EliminarPersona(elimina);
        }
        public static List<Zonas> ObtenerZonas()
        {
            return NuevoDao.ObtenerZonas();
        }
    }
}
