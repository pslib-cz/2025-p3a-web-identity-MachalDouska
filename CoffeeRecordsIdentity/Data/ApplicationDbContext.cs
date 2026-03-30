using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRecordsIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<CoffeeCup> Cups { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.HasData(new IdentityRole
                {
                    Id = "1",
                    Name = "Administrátor",
                    NormalizedName = "Administrátor".ToUpper()
                });

                entity.HasData(new IdentityRole
                {
                    Id = "2",
                    Name = "User",
                    NormalizedName = "User".ToUpper()
                });
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            { 
                entity.HasData(new ApplicationUser
                {
                    Id = "3",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    PasswordHash = hasher.HashPassword(null, "123admin"),
                    EmailConfirmed = true
                });
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasData(new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "3"
                });
            });
        }
    }
}
