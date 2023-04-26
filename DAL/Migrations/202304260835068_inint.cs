namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inint : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 15),
                        ProductCategory = c.String(nullable: false, maxLength: 15),
                        ProductPrice = c.String(nullable: false, maxLength: 10),
                        ProdcutQuantity = c.String(nullable: false, maxLength: 15),
                        SelleingBy = c.String(maxLength: 128),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sellers", t => t.SelleingBy)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.SelleingBy)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Sname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 15),
                        PhoneNumber = c.String(nullable: false),
                        NidNumber = c.String(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sname)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Moderators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid);
            
            CreateTable(
                "dbo.User_Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Oid = c.Int(nullable: false),
                        Uid = c.Int(nullable: false),
                        PaymentBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Oid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
                .Index(t => t.Oid)
                .Index(t => t.Uid);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderType = c.String(),
                        OrderQuantity = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        SelleBy = c.String(maxLength: 128),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SelleBy)
                .Index(t => t.SelleBy)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Order", "Uid", "dbo.Users");
            DropForeignKey("dbo.User_Order", "Oid", "dbo.Orders");
            DropForeignKey("dbo.Orders", "SelleBy", "dbo.Sellers");
            DropForeignKey("dbo.Products", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "uid", "dbo.Users");
            DropForeignKey("dbo.Carts", "uid", "dbo.Users");
            DropForeignKey("dbo.Carts", "pid", "dbo.Products");
            DropForeignKey("dbo.Products", "SelleingBy", "dbo.Sellers");
            DropForeignKey("dbo.Sellers", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Moderators", "AdminId", "dbo.Admins");
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "SelleBy" });
            DropIndex("dbo.User_Order", new[] { "Uid" });
            DropIndex("dbo.User_Order", new[] { "Oid" });
            DropIndex("dbo.Reviews", new[] { "uid" });
            DropIndex("dbo.Moderators", new[] { "AdminId" });
            DropIndex("dbo.Sellers", new[] { "AdminId" });
            DropIndex("dbo.Products", new[] { "Order_Id" });
            DropIndex("dbo.Products", new[] { "SelleingBy" });
            DropIndex("dbo.Carts", new[] { "pid" });
            DropIndex("dbo.Carts", new[] { "uid" });
            DropTable("dbo.Orders");
            DropTable("dbo.User_Order");
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Moderators");
            DropTable("dbo.Admins");
            DropTable("dbo.Sellers");
            DropTable("dbo.Products");
            DropTable("dbo.Carts");
        }
    }
}
