using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class TypeOfAccount
    {
        public const string Cash = nameof(Cash);

        public const string Credit = nameof(Credit);

        public const string Bank = nameof(Bank);
    }

    public class TransactionType
    {
        public const string SalePayment = "Paiement Vente";

        public const string Deposit = "Depot";

        public const string Withdraw = "Retrait";

        public const string Transfer = "Transfert";
    }
    public class AccountType 
    {
        public decimal Amount { get; set; } = 0;

        public DateTime LastUpdated { get; set; }
    }
    public class Cash:AccountType
    {
        
    }

    public class Credit : AccountType
    {

    }

    public class Bank : AccountType
    {
        public string AccountNumber { get; set; } = null!;
    }
    public class Wallet:BaseEntity
    {
        public Cash Cash { get; set; } = new Cash();
        public Credit Credit { get; set; } = new Credit();
        public Bank Bank { get; set; } = new Bank();
        
        public ICollection<WalletMovement> WalletHistory { get; set; } = new Collection<WalletMovement>();
    }

    public class WalletMovement
    {
        public Guid Id { get; set; }
        public Guid? FromWalletId { get; set; }
        public string FromAccountType { get; set; } = TypeOfAccount.Cash;

        public Guid ToWalletId { get; set; }
        public Wallet? ToWallet { get; set; }
        public string ToAccountType { get; set; } = TypeOfAccount.Cash;

        public string TransType { get; set; } = TransactionType.Deposit;

        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
