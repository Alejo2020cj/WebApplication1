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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDHospitalEntities1 : DbContext
    {
        public BDHospitalEntities1()
            : base("name=BDHospitalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Boton> Boton { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<CitaMedicamento> CitaMedicamento { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<EstadoCita> EstadoCita { get; set; }
        public virtual DbSet<FormaFarmaceutica> FormaFarmaceutica { get; set; }
        public virtual DbSet<HistorialCita> HistorialCita { get; set; }
        public virtual DbSet<Medicamento> Medicamento { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoSangre> TipoSangre { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<TipoUsuarioPagina> TipoUsuarioPagina { get; set; }
        public virtual DbSet<TipoUsuarioPaginaBoton> TipoUsuarioPaginaBoton { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
