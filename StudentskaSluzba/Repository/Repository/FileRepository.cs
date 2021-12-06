using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using StudentskaSluzba.Models;
using StudentskaSluzba.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StudentskaSluzba.Repository.Repository
{
    public class FileRepository : IFileRepository
    {
        ApplicationDbContext db;

        public FileRepository()
        {
            db = new ApplicationDbContext();
        }

        public void GeneratePDFDocument(int predmetId, int rokId)
        {
            List<Student> studenti = new List<Student>();
            List<Rezultati> rezs = db.Rezultati.Where(x => x.PredmetId == predmetId).Where(x => x.Rok == rokId).Where(x => x.Ocena == 5).ToList();

            foreach(Rezultati rez in rezs)
            {
                studenti.Add(db.Studenti.Find(rez.StudentId));
            }

            studenti = studenti.OrderBy(x => x.BrojIndeksa).ToList();

            string currentLocation = HttpContext.Current.Server.MapPath("~/");

            PdfDocument document = new PdfDocument();
            PdfPage page = new PdfPage();
            document.AddPage(page);

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            XFont font = new XFont("Verdana", 18, XFontStyle.Bold);
            XFont font2 = new XFont("Verdana", 12, XFontStyle.Bold);
            XFont fontNormal = new XFont("Verdana", 11, XFontStyle.Regular);

            gfx.DrawString(
                  "SPISAK STUDENATA",
                  font,
                  XBrushes.Black,
                  new XRect(180, 30, page.Width, page.Height),
                  XStringFormats.TopLeft
            );

            gfx.DrawString(
                  "Predmet:",
                  font2,
                  XBrushes.Black,
                  new XRect(50, 110, page.Width, page.Height),
                  XStringFormats.TopLeft
            );


            gfx.DrawString(
                  db.Predmeti.Find(predmetId).NazivPredmeta,
                  fontNormal,
                  XBrushes.Black,
                  new XRect(51, 132, page.Width, page.Height),
                  XStringFormats.TopLeft
            );

            gfx.DrawString(
                  "Ispitni rok:",
                  font2,
                  XBrushes.Black,
                  new XRect(460, 110, page.Width, page.Height),
                  XStringFormats.TopLeft
            );


            gfx.DrawString(
                  db.IspitniRokovi.Find(rokId).NazivRoka,
                  fontNormal,
                  XBrushes.Black,
                  new XRect(460, 132, page.Width, page.Height),
                  XStringFormats.TopLeft
            );

            int heightStartPoint = 240;

            gfx.DrawString(
                  "Br.",
                  font2,
                  XBrushes.Black,
                  new XRect(90, 216, page.Width, page.Height),
                  XStringFormats.TopLeft
            );

            gfx.DrawString(
                  "Ime i prezime:",
                  font2,
                  XBrushes.Black,
                  new XRect(190, 216, page.Width, page.Height),
                  XStringFormats.TopLeft
            );

            gfx.DrawString(
              "Broj indeksa",
              font2,
              XBrushes.Black,
              new XRect(390, 216, page.Width, page.Height),
              XStringFormats.TopLeft
            );

            int n = 1;

            foreach (Student student in studenti)
            {
                gfx.DrawString(
                  $"{n}.",
                  fontNormal,
                  XBrushes.Black,
                  new XRect(90, heightStartPoint, page.Width, page.Height),
                  XStringFormats.TopLeft
                );

                gfx.DrawString(
                  student.Ime + " " + student.Prezime,
                  fontNormal,
                  XBrushes.Black,
                  new XRect(190, heightStartPoint, page.Width, page.Height),
                  XStringFormats.TopLeft
                );

                gfx.DrawString(
                  student.BrojIndeksa,
                  fontNormal,
                  XBrushes.Black,
                  new XRect(390, heightStartPoint, page.Width, page.Height),
                  XStringFormats.TopLeft
                );

                heightStartPoint += 24;
                n++;
            }


            document.Save(currentLocation + "StudentskaSluzbaIzvestaj.pdf");

            Process.Start(currentLocation + "StudentskaSluzbaIzvestaj.pdf");
        }
    }
    
}