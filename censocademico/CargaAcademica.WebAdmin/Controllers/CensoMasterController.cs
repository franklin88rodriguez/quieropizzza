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
            return View();
        }
    }
}