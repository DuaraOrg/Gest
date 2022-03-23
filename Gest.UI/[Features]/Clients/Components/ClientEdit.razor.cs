using Gest.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Gest.UI._Features_.Clients.Components
{
    public partial class ClientEdit
    {
    }
    public class ClientModel
    {
        public Guid? Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        public string Names => $"{FirstName} {LastName}";

        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Type { get; set; }

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public Guid? WalletId { get; set; }
        public Wallet? Wallet { get; set; }
    }
}
