using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public class PluralsightASPDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }

        public PluralsightASPDbContext(DbContextOptions<PluralsightASPDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

    
}