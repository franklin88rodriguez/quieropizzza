using CargaAcademica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargaAcademica.WebAdmin.Controllers
{
    public class CensoMasterController : Controller
    {

        CensoMaestroBL _CensosMasterBL;

        public CensoMasterController()//constructor para inicializar
        {
            _CensosMasterBL = new CensoMaestroBL();//inicializando variable _CensosMasterBL

        }
        // GET: CensoMaster
        public ActionResult Index()
        {
            var listadeCenso = _CensosMasterBL.ObtenerCensoDetalle();

            return View(listadeCenso);
        }

        public ActionResult Crear()
        {
            var nuevoCenso = new CensoMaestro();

            return View(nuevoCenso);
        }

        [HttpPost]
        public ActionResult Crear(CensoMaestro censo)
        {
            if (ModelState.IsValid)
            {
                _CensosMasterBL.GuardarCenso(censo);

                return RedirectToAction("Index");
            }

            return View(censo);
        }


        public ActionResult Editar(int id)
        {
            var censo = _CensosMasterBL.ObtenerCensoDetalle(id);

            return View(censo);
        }

        [HttpPost]
        public ActionResult Editar(CensoMaestro censo)
        {
            if (ModelState.IsValid)
            {
                _CensosMasterBL.GuardarCenso(censo);

                return RedirectToAction("Index");
            }

            return View(censo);
        }


    }
}