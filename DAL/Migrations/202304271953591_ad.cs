namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "AdminId", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "ModeratorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "ModeratorId", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "AdminId");
        }
    }
}
