namespace EFMigrationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDecanNameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculties", "DecanName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faculties", "DecanName");
        }
    }
}
