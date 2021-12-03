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

            //context.IspitniRokovi.AddOrUpdate(
            //    new IspitniRok() { Id = 1, NazivRoka = "Januarski rok", DatumPocetkaRoka = DateTime.Parse("01/14/2022"), DatumKrajaRoka = DateTime.Parse("01/25/2022") },
            //    new IspitniRok() { Id = 2, NazivRoka = "Februarski rok", DatumPocetkaRoka = DateTime.Parse("02/08/2022"), DatumKrajaRoka = DateTime.Parse("02/17/2022") },
            //    new IspitniRok() { Id = 3, NazivRoka = "Aprilski rok", DatumPocetkaRoka = DateTime.Parse("03/30/2022"), DatumKrajaRoka = DateTime.Parse("04/11/2022") },
            //    new IspitniRok() { Id = 4, NazivRoka = "Junski rok", DatumPocetkaRoka = DateTime.Parse("06/16/2022"), DatumKrajaRoka = DateTime.Parse("06/28/2022") },
            //    new IspitniRok() { Id = 5, NazivRoka = "Julski rok", DatumPocetkaRoka = DateTime.Parse("07/02/2022"), DatumKrajaRoka = DateTime.Parse("07/16/2022") },
            //    new IspitniRok() { Id = 6, NazivRoka = "Avgustovski rok", DatumPocetkaRoka = DateTime.Parse("08/22/2022"), DatumKrajaRoka = DateTime.Parse("01/25/2022") },
            //    new IspitniRok() { Id = 7, NazivRoka = "Septembarski rok", DatumPocetkaRoka = DateTime.Parse("09/05/2022"), DatumKrajaRoka = DateTime.Parse("09/13/2022") },
            //    new IspitniRok() { Id = 8, NazivRoka = "Oktobarski rok", DatumPocetkaRoka = DateTime.Parse("10/22/2022"), DatumKrajaRoka = DateTime.Parse("10/30/2022") },
            //    new IspitniRok() { Id = 9, NazivRoka = "Oktobarski I rok", DatumPocetkaRoka = DateTime.Parse("11/08/2022"), DatumKrajaRoka = DateTime.Parse("11/12/2022") },
            //    new IspitniRok() { Id = 10, NazivRoka = "Oktobarski II rok", DatumPocetkaRoka = DateTime.Parse("11/15/2022"), DatumKrajaRoka = DateTime.Parse("01/19/2022") }
            //);

            //context.Adrese.AddOrUpdate(
            //    new Adresa() { Id = 1, Grad = "Novi Sad", Ulica = "Gagarinova", Broj = "19" },
            //    new Adresa() { Id = 2, Grad = "Novi Sad", Ulica = "Krilova", Broj = "5" },
            //    new Adresa() { Id = 3, Grad = "Novi Sad", Ulica = "Puskinova", Broj = "7a" },
            //    new Adresa() { Id = 4, Grad = "Beograd", Ulica = "Tolstojeva", Broj = "113" },
            //    new Adresa() { Id = 5, Grad = "Beograd", Ulica = "Bul. Kralja Aleksandra", Broj = "191" },
            //    new Adresa() { Id = 6, Grad = "Beograd", Ulica = "Balkanska", Broj = "5" }
            //);

            //context.Studenti.AddOrUpdate(
            //    new Student() { Id = 1, Ime = "Marko", Prezime = "Markovic", BrojIndeksa = "PR 11/2017", AdresaId = 1, Password = "123" },
            //    new Student() { Id = 2, Ime = "Stevan", Prezime = "Stevic", BrojIndeksa = "PR 15/2017", AdresaId = 2, Password = "123" },
            //    new Student() { Id = 3, Ime = "Mirko", Prezime = "Mirkovic", BrojIndeksa = "PR 22/2017", AdresaId = 3, Password = "123" },
            //    new Student() { Id = 4, Ime = "Snezana", Prezime = "Snezic", BrojIndeksa = "PR 136/2017", AdresaId = 4, Password = "123" },
            //    new Student() { Id = 5, Ime = "Jelena", Prezime = "Jelovic", BrojIndeksa = "PR 566/2017", AdresaId = 5, Password = "123" },
            //    new Student() { Id = 6, Ime = "Predrag", Prezime = "Savic", BrojIndeksa = "PR 65/2017", AdresaId = 6, Password = "123" },
            //    new Student() { Id = 7, Ime = "Sinisa", Prezime = "Petrovic", BrojIndeksa = "PR 12/2017", AdresaId = 7, Password = "123" }
            //);

            //context.Ucionice.AddOrUpdate(
            //    new Ucionica() { Id = 1, Zgrada = "IT Centar", BrojUcionice = "214" },
            //    new Ucionica() { Id = 2, Zgrada = "Masinski institut", BrojUcionice = "A1B0" },
            //    new Ucionica() { Id = 3, Zgrada = "IT Centar", BrojUcionice = "331" },
            //    new Ucionica() { Id = 4, Zgrada = "IT Centar", BrojUcionice = "334" },
            //    new Ucionica() { Id = 5, Zgrada = "IT Centar", BrojUcionice = "336" },
            //    new Ucionica() { Id = 6, Zgrada = "Masinski institut", BrojUcionice = "MIA6" }
            //);

            //context.Profesori.AddOrUpdate(
            //    new Profesor() { Id = 1, Ime = "Predrag", Prezime = "Rakocevic", Citiranost = 34, Password = "123", Email = "prof1@app.com" },
            //    new Profesor() { Id = 2, Ime = "Dragan", Prezime = "Danilovic", Citiranost = 5, Password = "123", Email = "prof2@app.com" },
            //    new Profesor() { Id = 3, Ime = "Strahinja", Prezime = "Petrovic", Citiranost = 14, Password = "123", Email = "prof3@app.com" },
            //    new Profesor() { Id = 4, Ime = "Jelena", Prezime = "Rakocevic", Citiranost = 21, Password = "123", Email = "prof4@app.com" },
            //    new Profesor() { Id = 5, Ime = "Pavle", Prezime = "Stanisavljevic", Citiranost = 18, Password = "123", Email = "prof5@app.com" }
            //);

            //context.Predmeti.AddOrUpdate(
            //    new Predmet() { Id = 1, NazivPredmeta = "Baze podataka 1", BrojESPB = 8, ProfesorId = 2, SifraPredmeta = "PR822NN" },
            //    new Predmet() { Id = 2, NazivPredmeta = "Baze podataka 2", BrojESPB = 8, ProfesorId = 1, SifraPredmeta = "PR812NN" },
            //    new Predmet() { Id = 3, NazivPredmeta = "Algebra", BrojESPB = 6, ProfesorId = 5, SifraPredmeta = "PR822NM" },
            //    new Predmet() { Id = 4, NazivPredmeta = "Analiza", BrojESPB = 5, ProfesorId = 3, SifraPredmeta = "PR580LS" },
            //    new Predmet() { Id = 5, NazivPredmeta = "Distriburirani racunarski sistemi", BrojESPB = 4, ProfesorId = 5, SifraPredmeta = "PR004NL" },
            //    new Predmet() { Id = 7, NazivPredmeta = "Mikroprocesorski sistemi", BrojESPB = 5, ProfesorId = 4, SifraPredmeta = "RS93KM" },
            //    new Predmet() { Id = 8, NazivPredmeta = "Dinamika Fluida", BrojESPB = 3, ProfesorId = 2, SifraPredmeta = "RS96KM" },
            //    new Predmet() { Id = 9, NazivPredmeta = "Osnove elektrotehnike", BrojESPB = 9, ProfesorId = 2, SifraPredmeta = "SJ97OF" },
            //    new Predmet() { Id = 10, NazivPredmeta = "Modeliranje i simulacija sistema", BrojESPB = 8, ProfesorId = 5, SifraPredmeta = "PM91KE" },
            //    new Predmet() { Id = 11, NazivPredmeta = "Arhitektura racunara", BrojESPB = 6, ProfesorId = 1, SifraPredmeta = "SS03PE" },
            //    new Predmet() { Id = 12, NazivPredmeta = "Internet mreze 1", BrojESPB = 4, ProfesorId = 3, SifraPredmeta = "PE940MM" },
            //    new Predmet() { Id = 13, NazivPredmeta = "Internet mreze 2", BrojESPB = 4, ProfesorId = 3, SifraPredmeta = "KP399JF" }
            //);

            //context.TokoviStudija.AddOrUpdate(
            //    new TokStudija() { Id = 1, Godina = 1, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("06/16/2017") },
            //    new TokStudija() { Id = 2, Godina = 1, BrojUpisa = 1, Budzet = false, DatumUpisa = DateTime.Parse("08/06/2016") },
            //    new TokStudija() { Id = 3, Godina = 1, BrojUpisa = 2, Budzet = false, DatumUpisa = DateTime.Parse("02/02/2018") },
            //    new TokStudija() { Id = 4, Godina = 1, BrojUpisa = 3, Budzet = false, DatumUpisa = DateTime.Parse("01/24/2018") },
            //    new TokStudija() { Id = 5, Godina = 2, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("07/31/2018") },
            //    new TokStudija() { Id = 6, Godina = 2, BrojUpisa = 2, Budzet = false, DatumUpisa = DateTime.Parse("11/27/2019") },
            //    new TokStudija() { Id = 7, Godina = 2, BrojUpisa = 3, Budzet = false, DatumUpisa = DateTime.Parse("12/13/2022") },
            //    new TokStudija() { Id = 8, Godina = 2, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("05/11/2022") },
            //    new TokStudija() { Id = 9, Godina = 3, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("03/08/2022") },
            //    new TokStudija() { Id = 10, Godina = 3, BrojUpisa = 2, Budzet = false, DatumUpisa = DateTime.Parse("02/16/2022") },
            //    new TokStudija() { Id = 11, Godina = 3, BrojUpisa = 3, Budzet = false, DatumUpisa = DateTime.Parse("10/16/2022") },
            //    new TokStudija() { Id = 12, Godina = 3, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("09/16/2022") },
            //    new TokStudija() { Id = 13, Godina = 4, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("05/16/2022") },
            //    new TokStudija() { Id = 14, Godina = 4, BrojUpisa = 1, Budzet = true, DatumUpisa = DateTime.Parse("07/16/2022") },
            //    new TokStudija() { Id = 15, Godina = 4, BrojUpisa = 2, Budzet = false, DatumUpisa = DateTime.Parse("11/16/2022") }
            //);

            //context.ZvanjaProfesora.AddOrUpdate(
            //    new ZvanjeProfesora() { Id = 1, Zvanje = Zvanje.DOCENT, DatumDobijanjaZvanja = DateTime.Parse("07/16/2001") },
            //    new ZvanjeProfesora() { Id = 2, Zvanje = Zvanje.DOCENT, DatumDobijanjaZvanja = DateTime.Parse("11/03/2007") },
            //    new ZvanjeProfesora() { Id = 3, Zvanje = Zvanje.DOCENT, DatumDobijanjaZvanja = DateTime.Parse("07/07/2020") },
            //    new ZvanjeProfesora() { Id = 4, Zvanje = Zvanje.DOCENT, DatumDobijanjaZvanja = DateTime.Parse("02/14/2018") },
            //    new ZvanjeProfesora() { Id = 5, Zvanje = Zvanje.DOCENT, DatumDobijanjaZvanja = DateTime.Parse("05/22/2014") },


            //    new ZvanjeProfesora() { Id = 6, Zvanje = Zvanje.VANREDNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("04/29/2008") },
            //    new ZvanjeProfesora() { Id = 7, Zvanje = Zvanje.VANREDNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("07/16/2015") },
            //    new ZvanjeProfesora() { Id = 8, Zvanje = Zvanje.VANREDNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("02/08/2019") },
            //    new ZvanjeProfesora() { Id = 9, Zvanje = Zvanje.VANREDNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("07/16/2021") },

            //    new ZvanjeProfesora() { Id = 10, Zvanje = Zvanje.REDOVNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("12/12/2020") },
            //    new ZvanjeProfesora() { Id = 11, Zvanje = Zvanje.REDOVNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("07/16/2022") },
            //    new ZvanjeProfesora() { Id = 12, Zvanje = Zvanje.REDOVNI_PROFESOR, DatumDobijanjaZvanja = DateTime.Parse("07/16/2022") }
            //);

        }
    }
}
