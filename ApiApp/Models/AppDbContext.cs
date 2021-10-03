using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models
{
    public class AppDbContext : DbContext
    {
        //base like super in java
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //these used to create table 
        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(Entry =>
            //{
            //    Entry.HasMany<Post>().WithOne(p => p.User).HasForeignKey(p => p.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);
            //});
        }
    }
}