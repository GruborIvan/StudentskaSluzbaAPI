using StudentskaSluzba.Models;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class RokRepository : IRokRepository
    {
        ApplicationDbContext db;

        public RokRepository()
        {
            db = new ApplicationDbContext();
        }

        public void AddIspitniRok(IspitniRok rok)
        {
            db.IspitniRokovi.Add(rok);
            db.SaveChanges();
            FillIspitiForIspitniRok(rok.DatumPocetkaRoka,rok.DatumKrajaRoka,rok.Id);
        }

        public void FillIspitiForIspitniRok(DateTime startDate, DateTime endDate, int rokId)
        {
            Random r = new Random();
            Random r2 = new Random(Convert.ToInt32(DateTime.Now.Ticks / int.MaxValue));
            List<Predmet> predmeti = db.Predmeti.ToList();
            foreach(Predmet p in predmeti)
            {
                Ispit newIspit = new Ispit();
                newIspit.IspitniRokId = rokId;
                newIspit.DatumIVremeOdrzavanja = startDate.AddHours(r2.Next(0, (int)(endDate - startDate).TotalHours));
                newIspit.PredmetId = p.Id;
                newIspit.UcionicaId = r.Next(1, 6);
                db.Ispiti.Add(newIspit);
                db.SaveChanges();
            }
        }

        public IEnumerable<IspitniRok> GetIspitniRokovi()
        {
            List<IspitniRok> rokovi = db.IspitniRokovi.ToList();
            foreach(IspitniRok ir in rokovi)
            {
                ir.Ispiti = null;
            }
            return rokovi;
        }
    }
}