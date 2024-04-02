using Libs.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Libs
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Kitchen> Kitchen { get; set; }
        public DbSet<Account> Account{ get; set; }
        public DbSet<TableNumber> TableNumber { get; set; }
        public DbSet<Cashier> Cashier { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Cartlist> Cartlist { get; set; }
        public DbSet<Report> Report { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}