using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Gest.Core.Extensions
{
    public static class DbContextExtensions
    {
        public static int GetLastPaymentId(this GestDbContext context, Guid companyId)
        => context.Payments.Where(x => x.CompanyId == companyId)
            .OrderBy(x => x.CreatedAt)
            .LastOrDefault()?.PayementId ?? 0;
    }
}
