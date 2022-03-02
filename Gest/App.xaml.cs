using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Gest;

public partial class App : Application
{
	public App(GestDbContext db)
	{
		InitializeComponent();

		MainPage = new MainPage();
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
    }
}
