namespace Gest.Core.Entities
{
    public class UserCompanyRole
    {
        public const string Owner = "Propriétaire";
        public const string Employee = "Employé";
    }
    public class UserCompany
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        public string Role { get; set; } = UserCompanyRole.Employee;

        public DateTime Joined { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
