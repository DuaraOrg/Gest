using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gest.Core.Data
{
    public class GestDbContextFactory : IDesignTimeDbContextFactory<GestDbContext>
    {
        public GestDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GestDbContext>();
            var provider = "Sqlit";
            if(provider == "Sqlite")
            {
                optionsBuilder.UseSqlite("Data Source=app.db", b => b.MigrationsAssembly("Gest.SqliteMigration"));
            }
            else
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-43TH18V;Initial Catalog=DuaraDb;User Id=DESKTOP-43TH18V\\user;Integrated Security=true",
                    b => b.MigrationsAssembly("Gest.SqlServerMigration"));
            }

            return new GestDbContext(optionsBuilder.Options);
        }
    }
}
