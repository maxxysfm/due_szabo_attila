﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KözvelemenyKutatas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseKozvelemenyEntities : DbContext
    {
        public DatabaseKozvelemenyEntities()
            : base("name=DatabaseKozvelemenyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<FELHASZNALOIADATOK> FELHASZNALOIADATOKs { get; set; }
        public DbSet<KERDESEK> KERDESEKs { get; set; }
        public DbSet<KUTATASOK> KUTATASOKs { get; set; }
        public DbSet<LEADOTTVALASZOK> LEADOTTVALASZOKs { get; set; }
        public DbSet<VALASZOK> VALASZOKs { get; set; }
    }
}
