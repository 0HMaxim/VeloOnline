using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models
{
    public class BikeContext : DbContext
    {
        public DbSet<Bike> Bicycles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public BikeContext(DbContextOptions<BikeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override async void OnModelCreating(ModelBuilder builder)
        {
            //Role adminRole = new Role { RoleId = 1, Name = "admin" };
            //Role userRole = new Role { RoleId = 2, Name = "user" };


            //User admin = new User { UserName = "admin@gmail.com" };
            //IdentityResult result = await userManager.CreateAsync(admin, "qwerty");


            //User admin = new User { Id = 1, Login = "admin@gmail.com", Password = "qwerty", RoleId = 1 };

            //builder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            //builder.Entity<User>().HasData(new User[] { admin });
            base.OnModelCreating(builder);

        }
    }
}
