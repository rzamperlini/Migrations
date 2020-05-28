namespace Migrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using global::Migrations.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(u => u.ID,
                new Models.Users { ID = 1, UserName = "Rodrigo", Password = "123456", EmailAddress = "rodrigo@teste.com.br" },
                new Models.Users { ID = 2, UserName = "Fernando", Password = "123", EmailAddress = "fernando@teste.com.br" },
                new Models.Users { ID = 3, UserName = "Larissa", Password = "321", EmailAddress = "larissa@teste.com.br" });

            context.SaveChanges();
        }
    }
}
