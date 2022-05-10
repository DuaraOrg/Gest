using Blazored.LocalStorage;
using Gest.Core.Data;
using Gest.UI.Extensions;
using Gest.UI.Models;
using Gest.UI.Shared;
using Microsoft.EntityFrameworkCore;
using Radzen;

namespace Gest.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            var localConString = $"Data Source={FileSystem.AppDataDirectory}/app.db";
            builder.Services.AddDbContext<GestDbContext>(opt => 
               opt.UseSqlite(localConString, b => b.MigrationsAssembly("Gest.SqliteMigration")), ServiceLifetime.Singleton);
            builder.Services.AddSingleton(_ => new CurrentItems());
            builder.Services.AddSingleton<AdminNavState>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddMapster();
            builder.Services.AddBlazoredLocalStorage();

            return builder.Build();
        }
    }
}