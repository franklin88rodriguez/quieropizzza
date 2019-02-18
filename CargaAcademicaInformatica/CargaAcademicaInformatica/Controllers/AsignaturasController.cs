
using CargaAcademica.BL;
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
            var Asignatura = new CargaAcademicaBL();

            var ListaAsignatura = Asignatura.ObtenerAsignaturas();


            return View(ListaAsignatura);
        }
    }
}