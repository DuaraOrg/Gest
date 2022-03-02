using Gest.Core.Entities;
using Gest.Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Gest.Core.Data
{
    public class GestDbContext: DbContext
    {
        public GestDbContext(DbContextOptions<GestDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Company> Companies { get; set; } = null!;

        public DbSet<UserCompany> UserCompanies { get; set; } = null!;

        public DbSet<Branch> Branches { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<UserCompany>()
                .HasKey(uc => new { uc.UserId, uc.CompanyId });
            modelBuilder.Entity<UserCompany>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.Companies)
                .HasForeignKey(uc => uc.UserId);
            modelBuilder.Entity<UserCompany>()
                .HasOne(uc => uc.Company)
                .WithMany(c => c.Users)
                .HasForeignKey(uc => uc.CompanyId);

            var (hash, salt) = "Admin@243".HashPassword();
            var user = new User()
            {
                Id = new Guid("D5CCAD5B-6CBC-4993-96E3-E8CD7C76D8B9"),
                FirstName = "Admin",
                LastName = "Swala",
                Email = "admin@swala.com",
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTime.UtcNow
            };
            var userCompany = new UserCompany()
            {
                UserId = new Guid("D5CCAD5B-6CBC-4993-96E3-E8CD7C76D8B9"),
                CompanyId = new Guid("AFDC3370-ADB1-4DE9-AD12-7678145B4485"),
                Role = UserCompanyRole.Owner,
                Joined = DateTime.UtcNow
            };
            var company = new Company()
            {
                Id = new Guid("AFDC3370-ADB1-4DE9-AD12-7678145B4485"),
                Name = "Ets TUUNGANE",
                CreatedAt = DateTime.UtcNow,
                Adress = "Bunia",
            };
            var branch = new Branch()
            {
                Id = new Guid("453412A3-578B-446B-9406-BD7077BDCE01"),
                CompanyId = new Guid("AFDC3370-ADB1-4DE9-AD12-7678145B4485"),
                Name = "Default",
                CreatedAt = DateTime.UtcNow
            };

            modelBuilder.Entity<Company>()
                .HasData(company);
            modelBuilder.Entity<User>()
                .HasData(user);
            modelBuilder.Entity<Branch>()
                .HasData(branch);
            modelBuilder.Entity<UserCompany>()
                .HasData(userCompany);
        }
    }
}
