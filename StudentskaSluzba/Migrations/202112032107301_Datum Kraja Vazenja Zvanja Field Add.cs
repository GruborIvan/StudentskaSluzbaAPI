namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatumKrajaVazenjaZvanjaFieldAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ZvanjaProfesora", "DatumKrajaVazenjaZvanja", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ZvanjaProfesora", "DatumKrajaVazenjaZvanja");
        }
    }
}
