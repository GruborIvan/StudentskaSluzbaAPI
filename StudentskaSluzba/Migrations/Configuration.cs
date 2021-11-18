namespace StudentskaSluzba.Migrations
{
    using StudentskaSluzba.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentskaSluzba.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentskaSluzba.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.IspitniRokovi.AddOrUpdate(
                new IspitniRok() { Id = 1, NazivRoka = "Januarski rok", DatumPocetkaRoka = DateTime.Parse("01/14/2022"), DatumKrajaRoka = DateTime.Parse("01/25/2022")},
                new IspitniRok() { Id = 2, NazivRoka = "Februarski rok", DatumPocetkaRoka = DateTime.Parse("02/08/2022"), DatumKrajaRoka = DateTime.Parse("02/17/2022") },
                new IspitniRok() { Id = 3, NazivRoka = "Aprilski rok", DatumPocetkaRoka = DateTime.Parse("03/30/2022"), DatumKrajaRoka = DateTime.Parse("04/11/2022") },
                new IspitniRok() { Id = 4, NazivRoka = "Junski rok", DatumPocetkaRoka = DateTime.Parse("06/16/2022"), DatumKrajaRoka = DateTime.Parse("06/28/2022") },
                new IspitniRok() { Id = 5, NazivRoka = "Julski rok", DatumPocetkaRoka = DateTime.Parse("07/02/2022"), DatumKrajaRoka = DateTime.Parse("07/16/2022") },
                new IspitniRok() { Id = 6, NazivRoka = "Avgustovski rok", DatumPocetkaRoka = DateTime.Parse("08/22/2022"), DatumKrajaRoka = DateTime.Parse("01/25/2022") },
                new IspitniRok() { Id = 7, NazivRoka = "Septembarski rok", DatumPocetkaRoka = DateTime.Parse("09/05/2022"), DatumKrajaRoka = DateTime.Parse("09/13/2022") },
                new IspitniRok() { Id = 1, NazivRoka = "Oktobarski rok", DatumPocetkaRoka = DateTime.Parse("10/22/2022"), DatumKrajaRoka = DateTime.Parse("10/30/2022") },
                new IspitniRok() { Id = 1, NazivRoka = "Oktobarski I rok", DatumPocetkaRoka = DateTime.Parse("11/08/2022"), DatumKrajaRoka = DateTime.Parse("11/12/2022") },
                new IspitniRok() { Id = 1, NazivRoka = "Oktobarski II rok", DatumPocetkaRoka = DateTime.Parse("11/15/2022"), DatumKrajaRoka = DateTime.Parse("01/19/2022") }
            );

        }
    }
}
