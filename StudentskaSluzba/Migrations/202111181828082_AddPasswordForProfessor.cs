namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPasswordForProfessor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profesori", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesori", "Password");
        }
    }
}
