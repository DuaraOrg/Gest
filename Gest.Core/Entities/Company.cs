using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class Company:BaseEntity
    {
        public string Name { get; set; } = null!;

        public string? Adress { get; set; }

        public decimal FCToDollarRate { get; set; } = 2000;

        public Guid? WalletId { get; set; }
        public Wallet? Wallet { get; set; }

        public ICollection<Branch> Branches { get; set; } = new Collection<Branch>();

        public ICollection<UserCompany> Users { get; set; } = new Collection<UserCompany>();

        public ICollection<Article> Articles { get; set; } = new Collection<Article>();

        public ICollection<Sale> Sales { get; set; } = new Collection<Sale>();
    }
}
