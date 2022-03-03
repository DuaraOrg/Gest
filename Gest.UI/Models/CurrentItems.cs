using Gest.Core.Entities;

namespace Gest.UI.Models
{
    public class CurrentItems
    {
        public Company? Company { get; set; }

        public User? User { get; set; }

        public DateTime DateOfOperations { get; set; } = DateTime.UtcNow;
    }
}
