﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToetsendRekenen
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Scores> Scores { get; set; }
        public DbSet<Sessies> Sessies { get; set; }
    
        public virtual ObjectResult<Nullable<int>> BetweenDates(Nullable<System.DateTime> datestart, Nullable<System.DateTime> dateend)
        {
            var datestartParameter = datestart.HasValue ?
                new ObjectParameter("Datestart", datestart) :
                new ObjectParameter("Datestart", typeof(System.DateTime));
    
            var dateendParameter = dateend.HasValue ?
                new ObjectParameter("Dateend", dateend) :
                new ObjectParameter("Dateend", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("BetweenDates", datestartParameter, dateendParameter);
        }
    }
}
