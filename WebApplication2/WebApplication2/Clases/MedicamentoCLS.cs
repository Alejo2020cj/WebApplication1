using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class MedicamentoCLS
    {
        [Display (Name ="id Medicamento")]
        public int iidmedicamento { get; set; }
        [Display(Name = "Nombre Medicamento")]
        [Required(ErrorMessage ="Ingrese el nombre del medicamento")]
        public string nombre { get; set; }
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Ingrese el Precio del medicamento")]
        public decimal precio { get; set; }
        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Ingrese el stock del medicamento")]
        public int stock { get; set; }
        [Display(Name = "Nombre Forma Farmaceutica")]
        [Required(ErrorMessage = "Ingrese la forma farmaceutica")]
        public string nombreFormaFarmaceutica { get; set; }
        [Display(Name = "Seleccione Forma Farmaceutica")]
        public int iidFormaFarmaceutica { get; set; }
        //Información adicional
        [Display(Name = "Concentracion")]
        public string concentracion { get; set; }
        [Display(Name = "Presentacion")]
        public string presentacion { get; set; }


    }
}