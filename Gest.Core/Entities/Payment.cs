namespace Gest.Core.Entities
{
    public class Payment:BaseEntity
    {
        public Guid? ClientId { get; set; }
        public Client? Client { get; set; }

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public decimal Amount { get; set; }
        public string AccountType { get; set; } = TypeOfAccount.Cash;
        public string TransType { get; set; } = TransactionType.Deposit;

        public Guid? SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
