using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public class PluralsightAspDbContext : IdentityDbContext<User>
    {
        //public DbSet<File> Files { get; set; }
        
        //public DbSet<Folder> Folders { get; set; }
        
        public DbSet<Course> Courses { get; set; }

        public PluralsightAspDbContext(DbContextOptions<PluralsightAspDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }

        /*
        builder.Entity<UsersFiles>(usersFiles =>
        {
            usersFiles.HasKey(x =>  new {x.UserId,x.FileId});
            
            usersFiles.HasOne(u => u.File).WithMany(f => f.UsersFiles).HasForeignKey(f => f.FileId);
            usersFiles.HasOne(u => u.User).WithMany(f => f.UsersFiles).HasForeignKey(f => f.UserId);
        });
        }*/
    }
}