using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CitamChoir.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Member> Members { get; set; }
        public DbSet<Occupation> Occupations { get; set; }


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