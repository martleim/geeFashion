﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeeFashion.DataModel
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class GeeFashionEntities : DbContext
    {
        public GeeFashionEntities()
            : base("name=GeeFashionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
    }
}
