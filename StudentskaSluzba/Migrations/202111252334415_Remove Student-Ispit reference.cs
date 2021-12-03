namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStudentIspitreference : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentIspits", "Student_Id", "dbo.Studenti");
            DropForeignKey("dbo.StudentIspits", "Ispit_Id", "dbo.Ispiti");
            DropIndex("dbo.StudentIspits", new[] { "Student_Id" });
            DropIndex("dbo.StudentIspits", new[] { "Ispit_Id" });
            DropTable("dbo.StudentIspits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentIspits",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Ispit_Id });
            
            CreateIndex("dbo.StudentIspits", "Ispit_Id");
            CreateIndex("dbo.StudentIspits", "Student_Id");
            AddForeignKey("dbo.StudentIspits", "Ispit_Id", "dbo.Ispiti", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentIspits", "Student_Id", "dbo.Studenti", "Id", cascadeDelete: true);
        }
    }
}
