namespace ATPapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAgenti",
                c => new
                    {
                        AgentiId = c.Int(nullable: false, identity: true),
                        NomeAgente = c.String(),
                        SiglaAgente = c.String(),
                    })
                .PrimaryKey(t => t.AgentiId);
            
            CreateTable(
                "dbo.tblClienti",
                c => new
                    {
                        ClientiId = c.String(nullable: false, maxLength: 128),
                        RagioneSociale = c.String(),
                        AgenteId = c.Int(nullable: false),
                        Agente_AgentiId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientiId)
                .ForeignKey("dbo.tblAgenti", t => t.Agente_AgentiId)
                .Index(t => t.Agente_AgentiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblClienti", "Agente_AgentiId", "dbo.tblAgenti");
            DropIndex("dbo.tblClienti", new[] { "Agente_AgentiId" });
            DropTable("dbo.tblClienti");
            DropTable("dbo.tblAgenti");
        }
    }
}
