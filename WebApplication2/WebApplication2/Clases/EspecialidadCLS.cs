using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Controllers;

namespace WebApplication2.Clases
{

    public class EspecialidadCLS
    {
        [Display(Name ="ID Especialidad")]
        public int iidespecialidad { get; set; }
        [Display(Name = "Nombre Especialidad")]
        [Required(ErrorMessage ="Ingrese el nombre de la especialidad")]
        public string nombre { get; set; }
        [Required(ErrorMessage ="Ingrese la descripcion")]
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
    }
}
