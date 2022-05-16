using Gest.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gest.UI._Features_.Users.Components
{
    public partial class UserEdit
    {
    }

    public class UserModel
    {
        public Guid? Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public User? User { get; set; }

        public string Role { get; set; } = UserRole.Guest;

        public Dictionary<string, List<PermissionCheck>> PermissionsCheck 
            = new Dictionary<string, List<PermissionCheck>>();

        public string Permissions { get; set; } = "";

        public string ProfileUrl { get; set; } = "";
    }
}
