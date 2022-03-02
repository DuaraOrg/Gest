using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? ProfileUrl { get; set; }

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;

        public ICollection<UserCompany> Companies { get; set; } = new Collection<UserCompany>();
    }
}
