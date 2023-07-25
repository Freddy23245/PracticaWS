using DAO;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ZonasNegocio
    {
        public static Zonas RegistrarZonas(Zonas nueva)
        {
            return ZonasDAO.RegistrarZonas(nueva);
        }
        public static Zonas ModificarZonas(Zonas modifica)
        {
            return ZonasDAO.ModificarZonas(modifica);
        }
        public static Zonas EliminarZonas(Zonas elimina)
        {
            return ZonasDAO.EliminarZonas(elimina);
        }
    }
}
