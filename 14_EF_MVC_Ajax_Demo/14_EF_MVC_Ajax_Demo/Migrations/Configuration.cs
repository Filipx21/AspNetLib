namespace _14_EF_MVC_Ajax_Demo.Migrations
{
    using Demo.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo.DAL.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo.DAL.PersonContext context)
        {
            PersonStoreInitializer.SeedUser(context);
        }
    }
}
