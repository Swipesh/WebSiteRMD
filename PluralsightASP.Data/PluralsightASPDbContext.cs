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
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            
            builder.Entity<UsersFiles>(usersFiles =>
            {
                usersFiles.HasKey(x =>  new {x.FileId, x.UserId});
                
                usersFiles.HasOne<File>(u => u.File).WithMany(f => f.UsersFiles).HasForeignKey(f => f.UserId);
                usersFiles.HasOne<User>(u => u.User).WithMany(f => f.UsersFiles).HasForeignKey(f => f.FileId);
            });
        }
    }
}