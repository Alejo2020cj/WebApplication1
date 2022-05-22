using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class SedeCLS
    {
        [Display(Name = "Id Sede")]
        public int iidSede { get; set; }
        [Display(Name = "Nombre Sede")]
        public string nombreSede { get; set; }
        [Display(Name = "Direccion Sede")]
        public string direccion { get; set; }
    }
}