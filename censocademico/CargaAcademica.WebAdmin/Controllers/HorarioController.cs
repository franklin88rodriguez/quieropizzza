using CargaAcademica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargaAcademica.WebAdmin.Controllers
{
    public class HorarioController : Controller
    {
        HorariosBL _HorarioBL;

        public HorarioController()
        {
            _HorarioBL = new HorariosBL();
        }


        // GET: Horario
        public ActionResult Index()
        {
            var ListadeHorarios = _HorarioBL.ObtenerHorarios();

            return View(ListadeHorarios);
        }

        public ActionResult Crear()
        {
            var nuevoHorario = new Horarios();

            return View(nuevoHorario);
        }

        [HttpPost]//validacion
        public ActionResult Crear (Horarios horario)
        {
            if (ModelState.IsValid)//validacion con estructura if que evalua si el model state es valio.
                                   //entonces permite guardar. 
            {
             /*   if (imagen != null)
                {
                    alumno.UrlImagen = GuardarImagen(imagen);
                }*/

                _HorarioBL.GuardarHorario(horario);


                return RedirectToAction("Index");
            }


            return View(horario);
        }
        public ActionResult Editar(int Id)
        {
            var hora = _HorarioBL.ObtenerHorarios(Id);

            return View(hora);
        }

        [HttpPost]
        public ActionResult Editar(Horarios hora)
        {
            if (ModelState.IsValid)
            {
                /*if(alumno.Id != alumno.Id.Trim())
                {

                }*/

            /*    if (imagen != null)
                {
                    alumno.UrlImagen = GuardarImagen(imagen);
                }*/
                _HorarioBL.GuardarHorario(hora);

                return RedirectToAction("Index");//pendiente index tambien
            }

            return View(hora);
        }


        public ActionResult Detalle(int Id)
        {
            var hora = _HorarioBL.ObtenerHorarios(Id);

            return View(hora);
        }

        [HttpPost]
        public ActionResult Eliminar(Horarios horario)
        {
            _HorarioBL.EliminarHorario(horario.Id);

            return RedirectToAction("Index");//pendiente index
        }

       
    }
}