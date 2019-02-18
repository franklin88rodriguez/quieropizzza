using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class CargaAcademicaBL
    {
       public List<Asignatura> ObtenerAsignaturas()
        {
            var Asignatura1 = new Asignatura();

            Asignatura1.Seccion = "Seccio: 1600,";
            Asignatura1.NumeroEdificio = "Edificio: 5,";
            Asignatura1.NombreAsignatura = "Asignatura: Lenguaje de Programacion 3,";
            Asignatura1.NombreCatedratico = "Catedratico: Franklin Xavier Rodriguez Santos,";

            var Asignatura2 = new Asignatura();

            Asignatura2.Seccion = "Seccion: 1700,";
            Asignatura2.NumeroEdificio = "Edificio: 5,";
            Asignatura2.NombreAsignatura = "Asignatura: Base de Datos 1,";
            Asignatura2.NombreCatedratico = "Catedratico: Edgar Antonio Zuniga,";



            var ListaAsignaturas = new List<Asignatura>();

            ListaAsignaturas.Add(Asignatura1);
            ListaAsignaturas.Add(Asignatura2);

            return ListaAsignaturas;
        }
    }
}
