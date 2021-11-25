using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace StudentskaSluzba.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<TokStudija> TokoviStudija { get; set; }
        public DbSet<Ucionica> Ucionice { get; set; }
        public DbSet<Ispit> Ispiti { get; set; }
        public DbSet<IspitniRok> IspitniRokovi { get; set; }
        public DbSet<ZvanjeProfesora> ZvanjaProfesora { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Rezultati> Rezultati { get; set; }
        public DbSet<Adresa> Adrese { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}