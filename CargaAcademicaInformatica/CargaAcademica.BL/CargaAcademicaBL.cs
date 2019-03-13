using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class CargaAcademicaBL
    {
        Contexto _contexto;
        public List<Asignatura> ListadeAsignaturas { get; set; }

        public CargaAcademicaBL()
        {
            _contexto = new Contexto();
            ListadeAsignaturas = new List<Asignatura>();

        }

        public List<Asignatura> ObtenerAsignatura()
        {
            ListadeAsignaturas = _contexto.Asignaturas.ToList();
            return ListadeAsignaturas;
        }

        public Asignatura ObtenerAsignatura(string seccion)
        {
            var producto = _contexto.Asignaturas.Find(seccion);

            return producto;
        }

        public void GuardarAsignatura(Asignatura asignatura)
        {
            if (asignatura.Seccion == 0)
            {
                _contexto.Asignaturas.Add(asignatura);
            }
            else
            {
                var asignaturaExistente = _contexto.Asignaturas.Find(asignatura.Seccion);
                asignaturaExistente.NumeroEdificio = asignatura.NumeroEdificio;
                asignaturaExistente.NombreAsignatura = asignatura.NombreAsignatura;
            }

            _contexto.SaveChanges();
        }

        public void EliminarAsignatura(string seccion)
        {
            var asignatura = _contexto.Asignaturas.Find(seccion);

            _contexto.Asignaturas.Remove(asignatura);
            _contexto.SaveChanges();

        }

        /*public List<Asignatura> ObtenerAsignaturas()
         {

             _contexto.Asignaturas.ToList();

          /*   var Asignatura1 = new Asignatura();

             Asignatura1.Seccion = "1600";
             Asignatura1.NumeroEdificio = "5";
             Asignatura1.NombreAsignatura = "Lenguaje de Programacion 3";
             Asignatura1.NombreCatedratico = "Franklin Xavier Rodriguez Santos";

             var Asignatura2 = new Asignatura();

             Asignatura2.Seccion = "1700";
             Asignatura2.NumeroEdificio = "5";
             Asignatura2.NombreAsignatura = "Base de Datos 1";
             Asignatura2.NombreCatedratico = "Edgar Antonio Zuniga";



             var ListaAsignaturas = new List<Asignatura>();

             ListaAsignaturas.Add(Asignatura1);
             ListaAsignaturas.Add(Asignatura2);

             return ListaAsignaturas;
         }*/
    } 
}
