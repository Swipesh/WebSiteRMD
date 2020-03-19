using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public class PluralsightASPDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PluralsightASPDbContext(DbContextOptions<PluralsightASPDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}