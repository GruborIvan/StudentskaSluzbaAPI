namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIspitIspitniRokFromListToField : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IspitniRokIspits", "IspitniRok_Id", "dbo.IspitniRokovi");
            DropForeignKey("dbo.IspitniRokIspits", "Ispit_Id", "dbo.Ispiti");
            DropIndex("dbo.IspitniRokIspits", new[] { "IspitniRok_Id" });
            DropIndex("dbo.IspitniRokIspits", new[] { "Ispit_Id" });
            AddColumn("dbo.Ispiti", "IspitniRokId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ispiti", "IspitniRokId");
            AddForeignKey("dbo.Ispiti", "IspitniRokId", "dbo.IspitniRokovi", "Id", cascadeDelete: true);
            DropTable("dbo.IspitniRokIspits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IspitniRokIspits",
                c => new
                    {
                        IspitniRok_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IspitniRok_Id, t.Ispit_Id });
            
            DropForeignKey("dbo.Ispiti", "IspitniRokId", "dbo.IspitniRokovi");
            DropIndex("dbo.Ispiti", new[] { "IspitniRokId" });
            DropColumn("dbo.Ispiti", "IspitniRokId");
            CreateIndex("dbo.IspitniRokIspits", "Ispit_Id");
            CreateIndex("dbo.IspitniRokIspits", "IspitniRok_Id");
            AddForeignKey("dbo.IspitniRokIspits", "Ispit_Id", "dbo.Ispiti", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IspitniRokIspits", "IspitniRok_Id", "dbo.IspitniRokovi", "Id", cascadeDelete: true);
        }
    }
}
