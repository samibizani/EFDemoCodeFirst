namespace MultiDataContextMigrations.UserDataContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MultiDataContextMigrations.Models.UserDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"UserDataContextMigrations";
        }

        protected override void Seed(MultiDataContextMigrations.Models.UserDataContext context)
        {

        }
    }
}
