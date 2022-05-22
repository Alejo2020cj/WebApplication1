using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Clases;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TipoUsuarioController : Controller
    {
        // GET: TipoUsuario
        public ActionResult Index( TipoUsuarioCLS oTipoUsuarioCLS)
        {
            List<TipoUsuarioCLS> listaTipoUsuario = new List<TipoUsuarioCLS>();
            using (BDHospitalEntities1 db = new BDHospitalEntities1())
            { 
                listaTipoUsuario = (from tipoUsuario in db.TipoUsuario
                                    where tipoUsuario.BHABILITADO==1
                                    select new TipoUsuarioCLS
                                    {
                                     iidTipoUsuario = tipoUsuario.IIDTIPOUSUARIO,
                                        nombre = tipoUsuario.NOMBRE,
                                        descripcion = tipoUsuario.DESCRIPCION


                                    }).ToList();
                if (oTipoUsuarioCLS.nombre == null && oTipoUsuarioCLS.descripcion == null
                    && oTipoUsuarioCLS.iidTipoUsuario == 0)
                {
                    ViewBag.Nombre = "";
                    ViewBag.Descripcion = "";
                    ViewBag.IidTipoUsuario = 0;

                }
                else
                {
                    if (oTipoUsuarioCLS.nombre != null)
                    {
                      listaTipoUsuario = listaTipoUsuario.Where(p=>p.nombre.Contains(oTipoUsuarioCLS.nombre)).ToList();
                    
                    }
                    if (oTipoUsuarioCLS.iidTipoUsuario != 0)
                    {
                        listaTipoUsuario = listaTipoUsuario.Where(p => p.iidTipoUsuario == oTipoUsuarioCLS.iidTipoUsuario).ToList();

                    }
                    if (oTipoUsuarioCLS.descripcion != null)
                    {
                        listaTipoUsuario = listaTipoUsuario.Where(p => p.descripcion.Contains(oTipoUsuarioCLS.descripcion)).ToList();

                    }
                    ViewBag.Nombre = oTipoUsuarioCLS.nombre;
                    ViewBag.Descripcion = oTipoUsuarioCLS.descripcion;
                    ViewBag.IidTipoUsuario = oTipoUsuarioCLS.iidTipoUsuario;


                }

                return View(listaTipoUsuario);

            }


             
        }
    }
}