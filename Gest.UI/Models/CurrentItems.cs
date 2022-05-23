using Gest.Core.Entities;

namespace Gest.UI.Models
{
    public class CurrentItems
    {
        public Company Company { get; set; } = null!;

        public Branch Branch { get; set; } = null!;

        public User User { get; set; } = null!;

        public string Theme { get; set; } = "dark";

        public DateTime DateOfOperations { get; set; } = DateTime.UtcNow.ToLocalTime();
    }
}
