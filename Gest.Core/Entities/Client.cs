namespace Gest.Core.Entities
{
    public class Client:BaseEntity
    {
        public string Names { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Type { get; set; }

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public Guid? WalletId { get; set; }
        public Wallet? Wallet { get; set; }
    }
}
