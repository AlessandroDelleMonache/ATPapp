using ATPapp.Infrastructure;
using ATPapp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ATPapp.Data
{
    public class ATPappContext : IdentityDbContext<ApplicationUser>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public System.Data.Entity.DbSet<ATPapp.Models.Agenti> Agentis { get; set; }

        public System.Data.Entity.DbSet<ATPapp.Models.Clienti> Clientis { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Agenti>()
                    .HasMany(e => e.Clienti)
                    .WithOptional(p => p.Agente).WillCascadeOnDelete(false);

            modelBuilder.Entity<Clienti>()
                        .HasOptional(e => e.Agente)
                        .WithMany(e => e.Clienti)
                        .HasForeignKey(e => e.AgentiId).WillCascadeOnDelete(false);
        }

        public ATPappContext()
            : base("ATPappContext", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static ATPappContext Create()
        {
            return new ATPappContext();
        }

    }
}
