﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjMgrAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectManagerSPAEntities : DbContext
    {
        public ProjectManagerSPAEntities()
            : base("name=ProjectManagerSPAEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<parent_task> parent_task { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<task> tasks { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
