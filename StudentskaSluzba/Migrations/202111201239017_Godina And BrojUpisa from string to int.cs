namespace StudentskaSluzba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GodinaAndBrojUpisafromstringtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TokoviStudija", "Godina", c => c.Int(nullable: false));
            AlterColumn("dbo.TokoviStudija", "BrojUpisa", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TokoviStudija", "BrojUpisa", c => c.String());
            AlterColumn("dbo.TokoviStudija", "Godina", c => c.String());
        }
    }
}
