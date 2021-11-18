namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ispiti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumIVremeOdrzavanja = c.DateTime(nullable: false),
                        UcionicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ucionice", t => t.UcionicaId, cascadeDelete: true)
                .Index(t => t.UcionicaId);
            
            CreateTable(
                "dbo.IspitniRokovi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivRoka = c.String(),
                        DatumPocetkaRoka = c.DateTime(nullable: false),
                        DatumKrajaRoka = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Predmeti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivPredmeta = c.String(),
                        SifraPredmeta = c.String(),
                        BrojESPB = c.Int(nullable: false),
                        ProfesorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profesori", t => t.ProfesorId, cascadeDelete: true)
                .Index(t => t.ProfesorId);
            
            CreateTable(
                "dbo.Profesori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Citiranost = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZvanjaProfesora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zvanje = c.Int(nullable: false),
                        DatumDobijanjaZvanja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rezultati",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        PredmetId = c.Int(nullable: false),
                        Rok = c.String(),
                        PredispitniPoeni = c.Double(nullable: false),
                        IspitniPoeni = c.Double(nullable: false),
                        Ocena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Predmeti", t => t.PredmetId, cascadeDelete: true)
                .ForeignKey("dbo.Studenti", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.PredmetId);
            
            CreateTable(
                "dbo.Studenti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        BrojIndeksa = c.String(),
                        Password = c.String(),
                        AdresaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.AdresaId, cascadeDelete: true)
                .Index(t => t.AdresaId);
            
            CreateTable(
                "dbo.Adrese",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grad = c.String(),
                        Ulica = c.String(),
                        Broj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TokoviStudija",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatumUpisa = c.DateTime(nullable: false),
                        Godina = c.String(),
                        BrojUpisa = c.String(),
                        Budzet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ucionice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zgrada = c.String(),
                        BrojUcionice = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IspitniRokIspits",
                c => new
                    {
                        IspitniRok_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IspitniRok_Id, t.Ispit_Id })
                .ForeignKey("dbo.IspitniRokovi", t => t.IspitniRok_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ispiti", t => t.Ispit_Id, cascadeDelete: true)
                .Index(t => t.IspitniRok_Id)
                .Index(t => t.Ispit_Id);
            
            CreateTable(
                "dbo.PredmetIspits",
                c => new
                    {
                        Predmet_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Predmet_Id, t.Ispit_Id })
                .ForeignKey("dbo.Predmeti", t => t.Predmet_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ispiti", t => t.Ispit_Id, cascadeDelete: true)
                .Index(t => t.Predmet_Id)
                .Index(t => t.Ispit_Id);
            
            CreateTable(
                "dbo.ZvanjeProfesoraProfesors",
                c => new
                    {
                        ZvanjeProfesora_Id = c.Int(nullable: false),
                        Profesor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ZvanjeProfesora_Id, t.Profesor_Id })
                .ForeignKey("dbo.ZvanjaProfesora", t => t.ZvanjeProfesora_Id, cascadeDelete: true)
                .ForeignKey("dbo.Profesori", t => t.Profesor_Id, cascadeDelete: true)
                .Index(t => t.ZvanjeProfesora_Id)
                .Index(t => t.Profesor_Id);
            
            CreateTable(
                "dbo.StudentIspits",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Ispit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Ispit_Id })
                .ForeignKey("dbo.Studenti", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ispiti", t => t.Ispit_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Ispit_Id);
            
            CreateTable(
                "dbo.TokStudijaStudents",
                c => new
                    {
                        TokStudija_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TokStudija_Id, t.Student_Id })
                .ForeignKey("dbo.TokoviStudija", t => t.TokStudija_Id, cascadeDelete: true)
                .ForeignKey("dbo.Studenti", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.TokStudija_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ispiti", "UcionicaId", "dbo.Ucionice");
            DropForeignKey("dbo.TokStudijaStudents", "Student_Id", "dbo.Studenti");
            DropForeignKey("dbo.TokStudijaStudents", "TokStudija_Id", "dbo.TokoviStudija");
            DropForeignKey("dbo.Rezultati", "StudentId", "dbo.Studenti");
            DropForeignKey("dbo.StudentIspits", "Ispit_Id", "dbo.Ispiti");
            DropForeignKey("dbo.StudentIspits", "Student_Id", "dbo.Studenti");
            DropForeignKey("dbo.Studenti", "AdresaId", "dbo.Adrese");
            DropForeignKey("dbo.Rezultati", "PredmetId", "dbo.Predmeti");
            DropForeignKey("dbo.ZvanjeProfesoraProfesors", "Profesor_Id", "dbo.Profesori");
            DropForeignKey("dbo.ZvanjeProfesoraProfesors", "ZvanjeProfesora_Id", "dbo.ZvanjaProfesora");
            DropForeignKey("dbo.Predmeti", "ProfesorId", "dbo.Profesori");
            DropForeignKey("dbo.PredmetIspits", "Ispit_Id", "dbo.Ispiti");
            DropForeignKey("dbo.PredmetIspits", "Predmet_Id", "dbo.Predmeti");
            DropForeignKey("dbo.IspitniRokIspits", "Ispit_Id", "dbo.Ispiti");
            DropForeignKey("dbo.IspitniRokIspits", "IspitniRok_Id", "dbo.IspitniRokovi");
            DropIndex("dbo.TokStudijaStudents", new[] { "Student_Id" });
            DropIndex("dbo.TokStudijaStudents", new[] { "TokStudija_Id" });
            DropIndex("dbo.StudentIspits", new[] { "Ispit_Id" });
            DropIndex("dbo.StudentIspits", new[] { "Student_Id" });
            DropIndex("dbo.ZvanjeProfesoraProfesors", new[] { "Profesor_Id" });
            DropIndex("dbo.ZvanjeProfesoraProfesors", new[] { "ZvanjeProfesora_Id" });
            DropIndex("dbo.PredmetIspits", new[] { "Ispit_Id" });
            DropIndex("dbo.PredmetIspits", new[] { "Predmet_Id" });
            DropIndex("dbo.IspitniRokIspits", new[] { "Ispit_Id" });
            DropIndex("dbo.IspitniRokIspits", new[] { "IspitniRok_Id" });
            DropIndex("dbo.Studenti", new[] { "AdresaId" });
            DropIndex("dbo.Rezultati", new[] { "PredmetId" });
            DropIndex("dbo.Rezultati", new[] { "StudentId" });
            DropIndex("dbo.Predmeti", new[] { "ProfesorId" });
            DropIndex("dbo.Ispiti", new[] { "UcionicaId" });
            DropTable("dbo.TokStudijaStudents");
            DropTable("dbo.StudentIspits");
            DropTable("dbo.ZvanjeProfesoraProfesors");
            DropTable("dbo.PredmetIspits");
            DropTable("dbo.IspitniRokIspits");
            DropTable("dbo.Ucionice");
            DropTable("dbo.TokoviStudija");
            DropTable("dbo.Adrese");
            DropTable("dbo.Studenti");
            DropTable("dbo.Rezultati");
            DropTable("dbo.ZvanjaProfesora");
            DropTable("dbo.Profesori");
            DropTable("dbo.Predmeti");
            DropTable("dbo.IspitniRokovi");
            DropTable("dbo.Ispiti");
        }
    }
}
