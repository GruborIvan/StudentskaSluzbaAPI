namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DonKnw : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rezultati", "Rok", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezultati", "Rok", c => c.String());
        }
    }
}
