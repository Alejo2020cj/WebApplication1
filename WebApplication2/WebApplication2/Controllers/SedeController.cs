using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Clases;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SedeController : Controller
    {
        // GET: Sede
        public ActionResult Index(SedeCLS oSedeCLS)
        {
            List<SedeCLS> listaSede = new List<SedeCLS>();
            using (BDHospitalEntities1 bd = new BDHospitalEntities1())
            {
                if (oSedeCLS.nombreSede == "" || oSedeCLS.nombreSede == null)
                {
                    listaSede = (from sede in bd.Sede
                                 where sede.BHABILITADO == 1
                                 select new SedeCLS
                                 {
                                     iidSede = sede.IIDSEDE,
                                     nombreSede = sede.NOMBRE,
                                     direccion = sede.DIRECCION

                                 }).ToList();
                    ViewBag.nombreSede = "";
                }
                else
                {
                    listaSede = (from sede in bd.Sede
                                 where sede.BHABILITADO == 1
                                 && sede.NOMBRE.Contains(oSedeCLS.nombreSede)
                                 select new SedeCLS
                                 {
                                     iidSede = sede.IIDSEDE,
                                     nombreSede = sede.NOMBRE,
                                     direccion = sede.DIRECCION

                                 }).ToList();
                    ViewBag.nombreSede = oSedeCLS.nombreSede;
                }


            }

            return View(listaSede);
        }
    }
}