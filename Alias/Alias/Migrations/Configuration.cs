namespace Alias.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Alias.Context.WordsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Alias.Context.WordsContext context)
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

            context.Words.AddOrUpdate(
                    new Models.Word { Value = "Pomidoras", Description = "Vaisis" },
                    new Models.Word {  Value = "Aitvaras", Description = "Kazkoks dalykas kur skraido"},
                    new Models.Word { Value = "Sakute", Description = "PRietaisas valgyti" },
                    new Models.Word { Value = "Chemoterapija", Description = "Nuo vezio" },
                    new Models.Word { Value = "Robotizacija", Description = "procesas" },
                    new Models.Word { Value = "Dramblys", Description = "didelis gyvunas" }
                );
        }
    }
}
