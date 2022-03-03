using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class Stock
    {
        public double Minimum { get; set; } = 1;

        public double? Maximum { get; set; }

        public double Qty { get; set; } = 0;
    }

    public class Conditionnement
    {
        public string Name { get; set; } = null!;
        public double QtyPerUnitOfMeasure { get; set; }
    }

    public class Pricing
    {
        public decimal PerUnitOfMeasure { get; set; }

        public decimal? PerConditionnement { get; set; }
    }

    public class Article:BaseEntity
    {
        public string Name { get; set; } = null!;
        public string UnitOfMeasure { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public Stock Stock { get; set; } = new Stock();
        public Conditionnement? Conditionnement { get; set; }

        public string Category { get; set; } = "Autres";

        public Pricing Price { get; set; } = new Pricing();

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public Guid BranchId { get; set; }
        public Branch? Branch { get; set; }

        public ICollection<StockMouvement> Mouvements { get; set; } = new Collection<StockMouvement>();

        public ICollection<Sale> Sales { get; set; } = new Collection<Sale>();
    }

    public class StockState
    {
        public const string In = "Entrer";
        public const string Out = "Sortie";
        public const string Demaged = "Endomager";

    }
    public class StockMouvement
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public Article? Article { get; set; }

        public string State { get; set; } = StockState.Out;

        public decimal Qty { get; set; }

        public DateTime Date { get; set; }
    }
}
