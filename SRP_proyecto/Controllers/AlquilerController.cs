using SRP_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRP_proyecto.Controllers
{
    public class AlquilerController : Controller
    {
        BD_SRPEntities db = new BD_SRPEntities(); //Conexion BD

        private int indice(int id)
        {
            List<CarritoItem> alquiler = (List<CarritoItem> )Session["carrito"];
            for(int i = 0; i < alquiler.Count; i++)
            {
                if (alquiler[i].Espacio.IdEspacio == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public ActionResult espacioAlquiler()
        {
            return View();
        }
        [HttpPost]
        public JsonResult espacioAlquiler(int id,int cantidad)
        {// 1:10 min
            if (Session["carrito"] == null)
            {
                List<CarritoItem>alquiler=new List<CarritoItem>();
                alquiler.Add(new CarritoItem(db.tb_espacio.Find(id), cantidad));
                Session["carrito"]=alquiler;
            }
            else
            {
                List<CarritoItem> alquiler = (List<CarritoItem>) Session["carrito"];
                int posicion = indice(id);
                if(posicion==-1)
                    alquiler.Add(new CarritoItem(db.tb_espacio.Find(id),cantidad));
                else
                    alquiler[posicion].Cantidad += cantidad;
                Session["carrito"]=alquiler;
            }
            return Json(new {response=true},JsonRequestBehavior.AllowGet);
        }
        public ActionResult borrar(int id)
        {
            List<CarritoItem>alquiler=(List<CarritoItem>)Session["carrito"];
            alquiler.RemoveAt(indice(id));
            return View("espacioAlquiler");
        }
        public ActionResult procesarAlquiler()
        {
            List<CarritoItem> alquiler = (List<CarritoItem>)Session["carrito"];
            if(alquiler==null && alquiler.Count > 0)
            {
                BOLETA nuevaBoleta = new BOLETA();
            nuevaBoleta.num_boleta = nuevaBoleta.num_boleta;
                nuevaBoleta.fec_boleta = DateTime.Now;
                nuevaBoleta.idCliente = 1001;
                nuevaBoleta.idParqueo = 0;
                
                db.BOLETA.Add(nuevaBoleta);
                db.SaveChanges();
                Session["carrito"]=new List<CarritoItem>();
            }
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
} // senmana 10 : 1:30:15 min