using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Ekurhuleni.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public partial class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Ekurhuleni.Models.CustomerProfile> CustomerProfiles { get; set; }

       // public System.Data.Entity.DbSet<Ekurhuleni.Models.ApplicationUser> ApplicationUsers { get; set; }

        public System.Data.Entity.DbSet<Ekurhuleni.Models.Residents> Residents { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public System.Data.Entity.DbSet<Ekurhuleni.Models.ApplicationType> ApplicationTypes { get; set; }

        public System.Data.Entity.DbSet<Ekurhuleni.Models.CircuitBreaker> CircuitBreakers { get; set; }

        public System.Data.Entity.DbSet<Ekurhuleni.Models.Tarrifs> Tarrifs { get; set; }
    }
}