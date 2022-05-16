using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gest.Core.Entities
{
    public class AppSections
    {
        public const string Sales = "Ventes";
        public const string Cash = "Caisse";
        public const string Stock = "Stock";
        public const string Client = "Clients";
        public const string Report = "Rapports";
        public const string Users = "Utilisateurs";

        public static IEnumerable<string> All() => new List<string> { Sales, Cash, Stock, Client,Report, Users };
    }
    public class AppPermissions
    {
        public const string Read = "Lire";
        public const string Create = "Créer";
        public const string Update = "Mettre à jour";
        public const string Delete = "Supprimer";

        public static IEnumerable<string> All() => new List<string> { Read, Create, Update, Delete };
    }
    public class UserRole
    {
        public const string Admin = "Admin";
        public const string SuperAdmin = "Superadmin";
        public const string Employee = "Employe";
        public const string Client = "Client";
        public const string Guest = "Visiteur";
        public static IEnumerable<string> All()
            => new List<string>() { Admin, Employee, Client, Guest };
    }

    public class PermissionCheck
    {
        public string Permission { get; set; } = null!;

        public bool IsChecked { get; set; } = false;
    }
    public class User:BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public string? ProfileUrl { get; set; }

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;

        public ICollection<UserCompany> Companies { get; set; } = new Collection<UserCompany>();

        public ICollection<Sale> Sales { get; set; } = new Collection<Sale>();

        public string Role { get; set; } = UserRole.Guest;

        public string Permissions { get; set; } = "";
    }
}
