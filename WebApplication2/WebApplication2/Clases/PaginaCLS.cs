using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class PaginaCLS
    {
        [Display (Name = "IIdPagina")]
        public int iidPagina { get; set; }
        [Display (Name = "Mensaje")]
        public String mensaje { get; set; }
        [Display(Name = "Controlador")]
        public string controlador { get; set; }
        public string accion { get; set; }
  


    }
}