using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Clases;
using WebApplication2.Controllers;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonaController : Controller
    {
        //public void llenarSexo()
        //{ 
        //    //List<SelectLisItem>
        //    List<SelectListItem> listadoSexo = new List<SelectListItem>();
        //    using (BDHospitalEntities1 bd = new BDHospitalEntities1())
        //    {
        //        listadoSexo = (from sexo in bd.Sexo
        //                       where sexo.BHABILITADO == 1
        //                       select new SelectListItem
        //                       {
        //                           Text = sexo.NOMBRE,
        //                           Value = sexo.IIDSEXO.ToString()

        //                       }).ToString();
        //        listadoSexo.Insert(0, new SelectListItem
        //        { 
        //          Text = "--Seleccione--",
        //          Value = ""
        //        });
            
        //    }
        //    ViewBag.listaSexo = listadoSexo;
        
        //}
        // GET: Persona
        public ActionResult Index()
        {
            List<PersonaCLS> listaPersona = new List<PersonaCLS>();
            //llenarSexo();
            using (BDHospitalEntities1 bd = new BDHospitalEntities1())
                listaPersona = (from persona in bd.Persona
                join sexo in bd.Sexo
                on persona.IIDSEXO equals
                sexo.IIDSEXO
                where persona.BHABILITADO ==1
                select new PersonaCLS
                { 
                 iidPersona = persona.IIDPERSONA,
                 nombreCompleto = persona.NOMBRE+" " + persona.APPATERNO+" "+persona.APMATERNO, email = persona.EMAIL,
                 nombreSexo = sexo.NOMBRE
                 
                }).ToList();
                return View(listaPersona);
        }
    }
}