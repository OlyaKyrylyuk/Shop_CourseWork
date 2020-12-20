using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kursach.Models
{
    
    public class ApplicationContext : DbContext
        {

            public DbSet<Role> Roles { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Cart> Carts { get; set; }
            public DbSet<Buy> Buys { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
    
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            string adminRoleName = "Administrator";
            string userRoleName = "User";

            string adminEmail = "olha@gmail.com";
            string adminPassword = "1234";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, Surname  = "Kyrylyuk",Name = "Olha",Phone = "0958264962",Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }


    }
   

}
