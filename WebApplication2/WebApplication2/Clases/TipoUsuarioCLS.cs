using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Clases
{
    public class TipoUsuarioCLS
    {
        [Display(Name ="id Tipo Usuario")]
        public int iidTipoUsuario { get; set; }
        [Display(Name ="Nombre")]
        public string nombre { get; set; }
        [Display(Name ="Descripcion")]
        public string descripcion { get; set; }

    }
}