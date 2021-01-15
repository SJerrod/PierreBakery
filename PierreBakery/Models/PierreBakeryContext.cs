using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Entity.FrameworkCore;

namespace PierreBakery.Models
{
    public class PierreBakeryContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<Treat> Treats { get; set; }
        public DbSet<FlavorTreat> FlavorTreat { get; set; }
        public PierreBakeryContext(DbContextOptions options) : base(options) { }
    }
}