using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class DeliveryStatus
    {
        public const string Pending = "En attente";

        public const string InDelivery = "En cours";

        public const string Delivered = "Livré";
    }
    public class PaymentStatus
    {
        public const string Pending = "En attente";

        public const string InPayement = "En cours";

        public const string Paid = "Payé";
    }
    public class SaleItem
    {
        public Guid ArticleId { get; set; }
        public Article? Article { get; set; }

        public double QtyInUnitOfMeasure { get; set; }

        public double QtyDelivered { get; set; }

        public decimal UnitPricePerUnitOfMeasure { get; set; }

        public decimal SubTotal => UnitPricePerUnitOfMeasure * (decimal)QtyInUnitOfMeasure;
    }
    public class Sale:BaseEntity
    {
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }

        public string PayStatus { get; set; } = PaymentStatus.Pending;

        public string DeliverStatus { get; set; } = DeliveryStatus.Pending;

        public decimal TotalAmount { get; set; } = 0;

        public decimal AmountPaid { get; set; } = 0;

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<SaleItem> Items { get; set; } = new Collection<SaleItem>();

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public Guid BranchId { get; set; }
        public Branch? Branch { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
