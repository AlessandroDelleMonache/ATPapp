namespace ATPapp.Migrations
{
    using ATPapp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ATPapp.Data.ATPappContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ATPapp.Data.ATPappContext context)
        {
            context.Agentis.Add(new Agenti { NomeAgente = "Carmine Ciriaco", SiglaAgente = "CC" });
            context.SaveChanges();
        }
    }
}
