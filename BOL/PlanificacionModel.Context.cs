﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlanificacionDbEntities : DbContext
    {
        public PlanificacionDbEntities()
            : base("name=PlanificacionDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Indicador> Indicador { get; set; }
        public virtual DbSet<Metodo> Metodo { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Planificacion> Planificacion { get; set; }
        public virtual DbSet<Sistematizacion> Sistematizacion { get; set; }
        public virtual DbSet<Trabajo> Trabajo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
