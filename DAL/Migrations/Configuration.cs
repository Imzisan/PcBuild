namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PcBuildContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.PcBuildContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //for(int i = 1; i <= 10; i++)
            //{
            //    context.Admins.AddOrUpdate(new Models.Admin
            //    {
            //        Name=Guid.NewGuid().ToString().Substring(0,15),
            //        UserName="Admin-"+i,
            //        Password=Guid.NewGuid().ToString().Substring(0,10),
            //        Phone= Guid.NewGuid().ToString().Substring(0, 10)
            //    });
            //}
            //Random  random = new Random();
            //for(int i = 1;i <= 15;i++)
            //{
            //    context.Moderators.AddOrUpdate(new Models.Moderator
            //    {
            //        Name = Guid.NewGuid().ToString().Substring(0, 15),
            //        UserName = "Moderator-" + i,
            //        Password = Guid.NewGuid().ToString().Substring(0, 10),
            //        Phone = Guid.NewGuid().ToString().Substring(0, 10),
            //        Email = Guid.NewGuid().ToString().Substring(0, 10),
            //        Salary =25000,
            //        AddedBy= "Admin-" + random.Next(1, 11)

            //    });

            //}
          
            //for(int i = 1;i<=40; i++)
            //{
            //    context.SalesReports.AddOrUpdate(new Models.SalesReport
            //    {
            //        Id = i,
            //        MonthName = Guid.NewGuid().ToString().Substring(0, 5),
            //        TotalSales =random.Next(20000,50000),
            //        ReportedBy = "Moderator-" + random.Next(1,15),
                  

            //    });
            //}
            //context.Moderators.AddOrUpdate(new Models.Moderator
            //{
            //    Id = i,
            //    Name = Guid.NewGuid().ToString().Substring(0, 5),
            //    Password = Guid.NewGuid().ToString().Substring(0, 10),
            //    Phone = Guid.NewGuid().ToString().Substring(0, 10),
            //    Email = Guid.NewGuid().ToString().Substring(0, 10),
            //    Salary = 25000,
            //    AddedBy = "Admin-" + random.Next(1, 11)

            //});

        }
    }
}
