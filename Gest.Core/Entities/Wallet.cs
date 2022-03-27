using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class TypeOfAccount
    {
        public const string Cash = nameof(Cash);

        public const string Credit = nameof(Credit);

        public const string Bank = nameof(Bank);

        public const string Expense = nameof(Expense);

        public static IEnumerable<string> All() => new List<string>() { Cash, Credit,Bank,Expense };
    }

    public class TransactionType
    {
        public const string SalePayment = "Paiement Vente";

        public const string Deposit = "Depot";

        public const string Withdraw = "Retrait";

        public const string Transfer = "Transfert";

        public const string Expense = "Dépense";

        public const string Tous = "Tous";

        public static IEnumerable<string> All() => new List<string>() { Expense, Deposit,SalePayment, Withdraw, Transfer };
        public static IEnumerable<string> AllWithTous() => new List<string>() { Tous,Expense, Deposit, SalePayment, Withdraw, Transfer };
    }
    public class AccountType 
    {
        public decimal Amount { get; set; } = 0;

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
    public class Cash:AccountType
    {
        
    }

    public class Credit : AccountType
    {

    }

    public class Expense : AccountType
    {

    }

    public class Bank : AccountType
    {
        public Bank()
        {
            AccountNumber = "000000000";
        }
        public string AccountNumber { get; set; } = null!;
    }
    public class Wallet:BaseEntity
    {
        public Cash Cash { get; set; } = new Cash();
        public Credit Credit { get; set; } = new Credit();
        public Bank Bank { get; set; } = new Bank();

        public Expense Expense { get; set; } = new Expense();
        
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
