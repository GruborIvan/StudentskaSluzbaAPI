namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IspitPredmetRelationChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PredmetIspits", "Predmet_Id", "dbo.Predmeti");
            DropForeignKey("dbo.PredmetIspits", "Ispit_Id", "dbo.Ispiti");
            DropIndex("dbo.PredmetIspits", new[] { "Predmet_Id" });
            DropIndex("dbo.PredmetIspits", new[] { "Ispit_Id" });
            AddColumn("dbo.Ispiti", "PredmetId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ispiti", "PredmetId");
            AddForeignKey("dbo.Ispiti", "PredmetId", "dbo.Predmeti", "Id", cascadeDelete: true);
            DropTable("dbo.PredmetIspits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PredmetIspits",
                c => new
                    {
                        Predmet_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Predmet_Id, t.Ispit_Id });
            
            DropForeignKey("dbo.Ispiti", "PredmetId", "dbo.Predmeti");
            DropIndex("dbo.Ispiti", new[] { "PredmetId" });
            DropColumn("dbo.Ispiti", "PredmetId");
            CreateIndex("dbo.PredmetIspits", "Ispit_Id");
            CreateIndex("dbo.PredmetIspits", "Predmet_Id");
            AddForeignKey("dbo.PredmetIspits", "Ispit_Id", "dbo.Ispiti", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PredmetIspits", "Predmet_Id", "dbo.Predmeti", "Id", cascadeDelete: true);
        }
    }
}
