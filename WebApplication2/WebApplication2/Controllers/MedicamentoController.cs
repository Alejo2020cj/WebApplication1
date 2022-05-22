using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using WebApplication2.Clases;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MedicamentoController : Controller
    {
        public List<SelectListItem> listarFormaFarmaceutica()
        {
            List<SelectListItem> listaFormaFarmaceutica = new List<SelectListItem>();
            using (BDHospitalEntities1 db = new BDHospitalEntities1())
            {
                listaFormaFarmaceutica = (from formafarma in db.FormaFarmaceutica
                                          where formafarma.BHABILITADO == 1
                                          select new SelectListItem
                                          {
                                              Text = formafarma.NOMBRE,
                                              Value = formafarma.IIDFORMAFARMACEUTICA.ToString()
                                          }).ToList();
                listaFormaFarmaceutica.Insert(0, new SelectListItem
                {
                    Text = "--Seleccione--",
                    Value = ""
                });
            }
            return listaFormaFarmaceutica;

        }

        public ActionResult Agregar()
        {
            ViewBag.listaFormaFarmaceutica = listarFormaFarmaceutica();
            return  View();
        }
        // GET: Medicamento
        public ActionResult Index(MedicamentoCLS oMedicamentoCLS)
        {
            ViewBag.listaForma = listarFormaFarmaceutica();
            List<MedicamentoCLS> listaMedicamento = new List<MedicamentoCLS>();
            using (BDHospitalEntities1 bd = new BDHospitalEntities1())
            {
                if (oMedicamentoCLS.iidmedicamento == null || oMedicamentoCLS.iidFormaFarmaceutica == 0)


                {
                    listaMedicamento = (from medicamento in bd.Medicamento
                                        join formafarmaceutica in bd.FormaFarmaceutica
                                        on medicamento.IIDFORMAFARMACEUTICA equals
                                        formafarmaceutica.IIDFORMAFARMACEUTICA
                                        where medicamento.BHABILITADO==1
                                        select new MedicamentoCLS
                                        {
                                            iidmedicamento = medicamento.IIDMEDICAMENTO,
                                            nombre = medicamento.NOMBRE,
                                            precio = (decimal)medicamento.PRECIO,
                                            stock = (int)medicamento.STOCK,
                                            nombreFormaFarmaceutica = formafarmaceutica.NOMBRE
                                        }).ToList();
                }
                else
                {
                    listaMedicamento = (from medicamento in bd.Medicamento
                                        join formafarmaceutica in bd.FormaFarmaceutica
                                        on medicamento.IIDFORMAFARMACEUTICA equals
                                        formafarmaceutica.IIDFORMAFARMACEUTICA
                                        where medicamento.BHABILITADO == 1
                                        && medicamento.IIDFORMAFARMACEUTICA==oMedicamentoCLS.iidFormaFarmaceutica
                                        select new MedicamentoCLS
                                        {
                                            iidmedicamento = medicamento.IIDMEDICAMENTO,
                                            nombre = medicamento.NOMBRE,
                                            precio = (decimal)medicamento.PRECIO,
                                            stock = (int)medicamento.STOCK,
                                            nombreFormaFarmaceutica = formafarmaceutica.NOMBRE
                                        }).ToList();

                }
            
            }
                return View (listaMedicamento);
        }
    }
}