using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Personas
    {
        public int id { get; set; }
        public string Cuil { get; set; }
        public string ApellidoYNombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int idZona { get; set; }
        public string Zona { get; set; }
    }
}
