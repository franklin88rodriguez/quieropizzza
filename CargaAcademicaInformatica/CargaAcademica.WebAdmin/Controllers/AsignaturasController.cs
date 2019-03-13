using CargaAcademica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargaAcademica.WebAdmin.Controllers
{
    public class AsignaturasController : Controller
    {
        CargaAcademicaBL _AsignaturaBL;

        public AsignaturasController()
        {
            _AsignaturaBL = new CargaAcademicaBL();
        }




        // GET: Asignaturas
        public ActionResult Index()
        {
            var listadeAsignaturas = _AsignaturaBL.ObtenerAsignatura();

            return View(listadeAsignaturas);
        }

        public ActionResult Crear()
        {
            var nuevaAsignatura = new Asignatura();

            return View(nuevaAsignatura);
        }

        [HttpPost]
        public ActionResult Crear(Asignatura asignatura)
        {
            _AsignaturaBL.GuardarAsignatura(asignatura);

            return RedirectToAction("Index");
        }


        public ActionResult Editar(int seccion)
        {
            var asignatura = _AsignaturaBL.ObtenerAsignatura(seccion);

            return View(asignatura);
        }

        [HttpPost]
        public ActionResult Editar(Asignatura asignatura)
        {
            _AsignaturaBL.GuardarAsignatura(asignatura);

            return RedirectToAction("Index");
        }


        public ActionResult Detalle(int seccion)
        {
            var asignatura = _AsignaturaBL.ObtenerAsignatura(seccion);

            return View(asignatura);
        }

        public ActionResult Eliminar(int seccion)
        {
            var asignatura = _AsignaturaBL.ObtenerAsignatura(seccion);
            return View(asignatura);
        }
        [HttpPost]
        public ActionResult Eliminar(Asignatura asignatura)
        {
            _AsignaturaBL.EliminarAsignatura(asignatura.Seccion);

            return RedirectToAction("Index");
        }
    }
}