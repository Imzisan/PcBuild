namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "ExpiredAt", c => c.DateTime());
            AddColumn("dbo.Tokens", "ModeratorId", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "DeletedAt");
            DropColumn("dbo.Tokens", "AdminName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "AdminName", c => c.String());
            AddColumn("dbo.Tokens", "DeletedAt", c => c.DateTime());
            DropColumn("dbo.Tokens", "ModeratorId");
            DropColumn("dbo.Tokens", "ExpiredAt");
        }
    }
}
