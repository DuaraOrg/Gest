using System.Collections.ObjectModel;

namespace Gest.Core.Entities
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; } = null!;

        public decimal FCToDollarRate { get; set; } = 2000;

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public ICollection<Sale> Sales { get; set; } = new Collection<Sale>();
    }
}
