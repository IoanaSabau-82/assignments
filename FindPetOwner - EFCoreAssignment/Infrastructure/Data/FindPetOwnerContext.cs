using Domain;
using FindPetOwner;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Infrastructure.EntityConfigurations;

namespace Infrastructure.Data
{
    public class FindPetOwnerContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<FoundPetPost> FoundPetPosts { get; set; }
        public DbSet<AssignedVolunteer> AssignedVolunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .UseSqlServer("Server=DESKTOP-A30MN5U\\SQLEXPRESS;Database=FindPetOwnerDatabase;Trusted_Connection=True;");
        }
    }
}