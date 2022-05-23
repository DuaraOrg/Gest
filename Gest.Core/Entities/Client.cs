using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class ClientKeys
    {
        public const string DefaultClientName = "Client Anonyme";
    }
    public class ClientState
    {
        public const string Tous = "Tous";
        public const string InDebt = "En dette";
        public const string WithDeliveryPending = "En attente de livraison";
        public static IEnumerable<string> AllWithTous() => new List<string>() { Tous,InDebt,WithDeliveryPending };

        public static IEnumerable<string> All() => new List<string>() { InDebt,WithDeliveryPending };
    }
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

        public ICollection<Sale> Sales { get; set; } = new Collection<Sale>();
    }
}
