using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Clases;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class PaginaController : Controller
    {
        // GET: Pagina
        public ActionResult Index(PaginaCLS oPaginaCLS)
        {
            List<PaginaCLS> listaPagina = new List<PaginaCLS>();
            using (BDHospitalEntities1 bd = new BDHospitalEntities1())
                if (oPaginaCLS.mensaje == null || oPaginaCLS.mensaje == "")
                {
                   
                    listaPagina = (from pagina in bd.Pagina
                                   where pagina.BHABILITADO == 1
                                   select new PaginaCLS
                                   {
                                       iidPagina = pagina.IIDPAGINA,
                                       mensaje = pagina.MENSAJE,
                                       accion = pagina.ACCION,
                                       controlador = pagina.CONTROLADOR,

                                   }).ToList();
                    ViewBag.mensajeBuscar = "";

                }
                else
                {
                    listaPagina = (from pagina in bd.Pagina
                                   where pagina.BHABILITADO == 1
                                   && pagina.MENSAJE.Contains(oPaginaCLS.mensaje)
                                   select new PaginaCLS
                                   {
                                       iidPagina = pagina.IIDPAGINA,
                                       mensaje = pagina.MENSAJE,
                                       accion = pagina.ACCION,
                                       controlador = pagina.CONTROLADOR,

                                   }).ToList();
                    ViewBag.mensajeBuscar = oPaginaCLS.mensaje;


                }

            return View(listaPagina);
        }
    }
}