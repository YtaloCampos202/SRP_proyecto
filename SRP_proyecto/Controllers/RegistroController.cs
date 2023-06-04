using SRP_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRP_proyecto.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        private BD_SRPEntities db= new BD_SRPEntities();

        public ActionResult Index()
        {
            return View(db.tb_espacio .ToList().OrderBy(X=>X.Numero));
        }
    }
}