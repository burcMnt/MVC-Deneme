using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppMVC.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, UserName = "Ali", Password = "12345" },
                new User() { Id = 2, UserName = "Can", Password = "1234" },
                new User() { Id = 3, UserName = "Cem", Password = "123" }
                );
            modelBuilder.Entity<Task>().HasData(
                new Task() { Id = 1, Description = "Alısveris" },
                new Task() { Id = 2, Description = "Spor" },
                new Task() { Id = 3, Description = "Gezi" }
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
