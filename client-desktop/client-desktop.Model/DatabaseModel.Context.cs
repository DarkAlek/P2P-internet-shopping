﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client_desktop.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseModelContainer : DbContext
    {
        public DatabaseModelContainer()
            : base("name=DatabaseModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<Service> ServiceSet { get; set; }
        public virtual DbSet<Region> RegionSet { get; set; }
        public virtual DbSet<ServiceChoosed> ServiceChoosedSet { get; set; }
        public virtual DbSet<Rate> RateSet { get; set; }
    }
}
