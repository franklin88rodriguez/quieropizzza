using CargaAcademicaInformatica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargaAcademicaInformatica.Controllers
{
    public class AsignaturasController : Controller
    {
        // GET: Asignaturas
        public ActionResult Index()
        {
            var Asignatura1 = new CargaAcademicaModel();
            Asignatura1.SeccionClase = 1600;
            Asignatura1.NombreClase = "Metodologia de la Programacion";

            var Asignatura2 = new CargaAcademicaModel();
            Asignatura2.SeccionClase = 1700;
            Asignatura2.NombreClase = "Taller de Hardware 1";

            var Asignatura3 = new CargaAcademicaModel();
            Asignatura3.SeccionClase = 2000;
            Asignatura3.NombreClase = "Lenguaje de Programacion 1";

            var Asignatura4 = new CargaAcademicaModel();
            Asignatura4.SeccionClase = 2000;
            Asignatura4.NombreClase = "Lenguaje de Programacion 2";

            var ListaAsignaturas = new List<CargaAcademicaModel>();

            ListaAsignaturas.Add(Asignatura1);
            ListaAsignaturas.Add(Asignatura2);
            ListaAsignaturas.Add(Asignatura3);
            ListaAsignaturas.Add(Asignatura4);
            return View(ListaAsignaturas);
        }
    }
}