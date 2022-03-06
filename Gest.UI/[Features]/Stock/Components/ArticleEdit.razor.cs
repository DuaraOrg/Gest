using System.ComponentModel.DataAnnotations;

namespace Gest.UI._Features_.Stock.Components
{
    public partial class ArticleEdit
    {
    }

    public class ArticleModel
    {
        public Guid? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public Guid CompanyId { get; set; }
        public Guid BranchId { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier un nom pour cet article")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier une unité de mesure")]
        public string UnitOfMeasure { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Range(double.Epsilon, double.MaxValue)]
        public double? StockMinimum { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier le stock minimum")]
        [Range(double.Epsilon, double.MaxValue)]
        public double? StockMaximum { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier la qté en Stock")]
        [Range(double.Epsilon, double.MaxValue)]
        public double? StockQty { get; set; }

        public string? ConditionementName { get; set; }

        [Range(double.Epsilon, double.MaxValue)]
        public double? ConditionnementQtyPerUnitOfMeasure { get; set; }

        public string? Category { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier un prix d'achat par unité de mesure")]
        [Range(double.Epsilon, double.MaxValue)]
        public decimal? BuyingPricePerUnitOfMeasure { get; set; }

        public decimal? BuyingPricePerConditionnement { get; set; }


        [Required(ErrorMessage = "Veuillez spécifier un prix de vente par unité de mesure")]
        [Range(double.Epsilon, double.MaxValue)]
        public decimal? SellingPricePerUnitOfMeasure { get; set; }

        public decimal? SellingPricePerConditionnement { get; set; }
    }
}
