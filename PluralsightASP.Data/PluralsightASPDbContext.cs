using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public class PluralsightASPDbContext : IdentityDbContext<User>
    {
        public DbSet<File> Files { get; set; }
        
        public DbSet<UsersFiles> UsersFiles { get; set; }

        public PluralsightASPDbContext(DbContextOptions<PluralsightASPDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(user => { user.HasMany<File>(); });

            builder.Entity<File>(file =>
            {
                file.ToTable("Files");
                file.HasKey(x => x.Id);
                file.HasMany<User>();
            });
        }*/
        
        
    }
}