using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Clases;

using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EspecialidadController : Controller
    {
        // GET: Especialidad
        public ActionResult Index(EspecialidadCLS oEspecialidadCLS)
        {
            List<EspecialidadCLS> listaEspecialidad = new List<EspecialidadCLS>();
            //ViewBag.Mensaje = "Estoy pasando un mensaje del controller a la vista";
            using (BDHospitalEntities1 db = new BDHospitalEntities1())
            {
                if (oEspecialidadCLS.nombre == null || oEspecialidadCLS.nombre == "")
                {

                    listaEspecialidad = (from especialidad in db.Especialidad
                                         where especialidad.BHABILITADO == 1
                                         select new EspecialidadCLS
                                         {
                                             iidespecialidad = especialidad.IIDESPECIALIDAD,
                                             nombre = especialidad.NOMBRE,
                                             descripcion = especialidad.DESCRIPCION
                                         }).ToList();
                    ViewBag.nombreEspecialidad = "";
                }
                else
                {

                    listaEspecialidad = (from especialidad in db.Especialidad
                                         where especialidad.BHABILITADO == 1
                                         && especialidad.NOMBRE.Contains(oEspecialidadCLS.nombre)
                                         select new EspecialidadCLS
                                         {
                                             iidespecialidad = especialidad.IIDESPECIALIDAD,
                                             nombre = especialidad.NOMBRE,
                                             descripcion = especialidad.DESCRIPCION
                                         }).ToList();
                    ViewBag.nombreEspecialidad = oEspecialidadCLS.nombre;

                }

            }
            return View(listaEspecialidad);
        }
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(EspecialidadCLS oEspecialidad)
        {
            try
            {
                //Conecxion a la base de datos
                using (BDHospitalEntities1 db = new BDHospitalEntities1())
                {
                    if (!ModelState.IsValid)
                    {
                        return View(oEspecialidad);
                    }
                    else
                    {
                        Especialidad objeto = new Especialidad();
                        objeto.NOMBRE = oEspecialidad.nombre;
                        objeto.DESCRIPCION = oEspecialidad.descripcion;
                        objeto.BHABILITADO = 1;
                        db.Especialidad.Add(objeto);
                        db.SaveChanges();

                    }




                }

            }
            catch (Exception ex)
            {
                return View(oEspecialidad);
            }
            return RedirectToAction("Index");
        }
    }
}