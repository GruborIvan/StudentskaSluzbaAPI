namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mistakefix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rezultati", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas");
            DropIndex("dbo.Rezultati", new[] { "TipPredispitnihObavezaId" });
            AddColumn("dbo.Predmeti", "TipPredispitnihObavezaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Predmeti", "TipPredispitnihObavezaId");
            AddForeignKey("dbo.Predmeti", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas", "Id", cascadeDelete: true);
            DropColumn("dbo.Rezultati", "TipPredispitnihObavezaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezultati", "TipPredispitnihObavezaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Predmeti", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas");
            DropIndex("dbo.Predmeti", new[] { "TipPredispitnihObavezaId" });
            DropColumn("dbo.Predmeti", "TipPredispitnihObavezaId");
            CreateIndex("dbo.Rezultati", "TipPredispitnihObavezaId");
            AddForeignKey("dbo.Rezultati", "TipPredispitnihObavezaId", "dbo.TipPredispitnihObavezas", "Id", cascadeDelete: true);
        }
    }
}
