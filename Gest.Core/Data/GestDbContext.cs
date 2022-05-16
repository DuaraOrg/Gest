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

        public DbSet<Article> Articles { get; set; } = null!;

        public DbSet<StockMouvement> StockMouvements { get; set; } = null!;

        public DbSet<Client> Clients { get; set; } = null!;

        public DbSet<Wallet> Wallets { get; set; } = null!;

        public DbSet<Sale> Sales { get; set; } = null!;

        public DbSet<Payment> Payments { get; set; } = null!;

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

            modelBuilder.Entity<Wallet>()
                .OwnsOne(x => x.Cash);
            modelBuilder.Entity<Wallet>()
               .OwnsOne(x => x.Credit);
            modelBuilder.Entity<Wallet>()
              .OwnsOne(x => x.Bank);
            modelBuilder.Entity<Wallet>()
              .OwnsOne(x => x.Expense);

            var (hash, salt) = "Admin@243".HashPassword();
            var user = new User()
            {
                Id = new Guid("D5CCAD5B-6CBC-4993-96E3-E8CD7C76D8B9"),
                FirstName = "Admin",
                LastName = "Swala",
                Email = "admin@swala.com",
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTime.UtcNow,
                Role = UserRole.SuperAdmin
            };
            user = user.GiveAllPermissions();
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
                Adress = "Bunia"
            };
            var branch = new Branch()
            {
                Id = new Guid("453412A3-578B-446B-9406-BD7077BDCE01"),
                CompanyId = new Guid("AFDC3370-ADB1-4DE9-AD12-7678145B4485"),
                Name = "Default",
                CreatedAt = DateTime.UtcNow
            };
            var defaultClient = new Client()
            {
                Id = new Guid("654412A3-578B-446B-9406-BD7077BDCE01"),
                Names = "Client Anonyme",
                Email = "clientanonyme@swala.com",
                CompanyId = new Guid("AFDC3370-ADB1-4DE9-AD12-7678145B4485"),
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
            modelBuilder.Entity<Client>()
            .HasData(defaultClient);

            modelBuilder.Entity<Company>()
                .HasMany(x => x.Articles)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Article>()
                .HasIndex(x => x.Name)
                .IsUnique();
            modelBuilder.Entity<Article>()
                .OwnsOne(x => x.Stock);
            modelBuilder.Entity<Article>()
                .OwnsOne(x => x.Conditionnement);
            modelBuilder.Entity<Article>()
                .OwnsOne(x => x.Price);

            modelBuilder.Entity<Sale>()
                .OwnsMany(x => x.Items, i => i.HasKey("Id"));
            modelBuilder.Entity<Client>()
                .HasMany(x => x.Sales)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Company>()
             .HasMany(x => x.Sales)
             .WithOne(x => x.Company)
             .HasForeignKey(x => x.CompanyId)
             .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Branch>()
            .HasMany(x => x.Sales)
            .WithOne(x => x.Branch)
            .HasForeignKey(x => x.BranchId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
            .HasMany(x => x.Sales)
            .WithOne(x => x.Seller)
            .HasForeignKey(x => x.SellerId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
