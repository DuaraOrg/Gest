using System.ComponentModel.DataAnnotations;

namespace Gest.UI._Features_.Funds.Components
{
    public partial class PaymentEdit
    {
    }

    public class PaymentModel
    {
        public Guid? Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier les noms de la personne bénéficiaire")]
        public string? ClientNames { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier une catégorie")]
        public string? Category { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier le montant")]
        public decimal? Amount { get; set; }
    }
}
