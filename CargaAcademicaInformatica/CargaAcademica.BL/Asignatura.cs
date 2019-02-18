using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class Asignatura
    {
        public string Seccion { get; set; }
        public string NumeroEdificio { get; set; }
        public string NombreAsignatura { get; set; }
        public string NombreCatedratico { get; set; }

        public static object ObtenerAsignaturas()
        {
            throw new NotImplementedException();
        }
    }
}
