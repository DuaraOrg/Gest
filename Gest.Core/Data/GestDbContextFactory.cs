using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gest.Core.Data
{
    public class GestDbContextFactory : IDesignTimeDbContextFactory<GestDbContext>
    {
        public GestDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GestDbContext>();
            optionsBuilder.UseSqlite("Data Source=app.db");

            return new GestDbContext(optionsBuilder.Options);
        }
    }
}
