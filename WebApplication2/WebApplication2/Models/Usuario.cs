//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Cita = new HashSet<Cita>();
            this.HistorialCita = new HashSet<HistorialCita>();
            this.Persona = new HashSet<Persona>();
        }
    
        public int IIDUSUARIO { get; set; }
        public int IIDTIPOUSUARIO { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
        public Nullable<int> IIDPERSONA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialCita> HistorialCita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual Persona Persona1 { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
