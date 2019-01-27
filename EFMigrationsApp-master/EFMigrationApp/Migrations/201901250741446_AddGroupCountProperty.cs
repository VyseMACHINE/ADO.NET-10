namespace EFMigrationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupCountProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculties", "GroupCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faculties", "GroupCount");
        }
    }
}
