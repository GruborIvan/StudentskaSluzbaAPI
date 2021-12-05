namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipPredispitnihObavezas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivTipa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rezultati", "TipPredispitnihObavezaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rezultati", "TipPredispitnihObavezaId");
            AddForeignKey("dbo.Rezultati", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezultati", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas");
            DropIndex("dbo.Rezultati", new[] { "TipPredispitnihObavezaId" });
            DropColumn("dbo.Rezultati", "TipPredispitnihObavezaId");
            DropTable("dbo.TipPredispitnihObavezas");
        }
    }
}
