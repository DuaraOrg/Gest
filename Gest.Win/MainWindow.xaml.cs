using Blazored.LocalStorage;
using Gest.Core.Data;
using Gest.UI.Extensions;
using Gest.UI.Models;
using Gest.UI.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using System;
using System.Linq;
using System.Windows;

namespace Gest.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            var localConString = $"Data Source=app.db";
            serviceCollection.AddDbContext<GestDbContext>(opt => opt.UseSqlite(localConString, b => b.MigrationsAssembly("Gest.SqliteMigration")), ServiceLifetime.Singleton);
            serviceCollection.AddBlazorWebView();

            serviceCollection.AddSingleton(_ => new CurrentItems());
            serviceCollection.AddSingleton<AdminNavState>();
            serviceCollection.AddScoped<DialogService>();
            serviceCollection.AddScoped<NotificationService>();
            serviceCollection.AddScoped<TooltipService>();
            serviceCollection.AddMapster();
            serviceCollection.AddBlazoredLocalStorage();
            var app = serviceCollection.BuildServiceProvider();
            using var serviceScope = app.CreateAsyncScope();
            var db = serviceScope.ServiceProvider.GetRequiredService<GestDbContext>();
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
            Resources.Add("services", app);

            InitializeComponent();
        }
    }
}
