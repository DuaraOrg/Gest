using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Sentry;

namespace Gest.Maui
{
    public partial class App : Application
    {
        public App(GestDbContext db)
        {
            InitializeComponent();

            if (db is not null)
            {
                try
                {
                    if (db.Database.GetPendingMigrations().Count() > 0)
                        db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MainPage = new MainPage();
        }
    }
}