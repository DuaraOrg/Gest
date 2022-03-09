using Microsoft.AspNetCore.Components.WebView.Maui;
using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Gest.UI.Models;
using Gest.UI.Shared;
using Radzen;
using Gest.UI.Extensions;

namespace Gest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>();
		var localConString = $"Data Source={FileSystem.AppDataDirectory}/app.db";
		builder.Services.AddDbContext<GestDbContext>(opt => opt.UseSqlite(localConString, b => b.MigrationsAssembly("Gest.SqliteMigration")),ServiceLifetime.Singleton);
		builder.Services.AddBlazorWebView();

		builder.Services.AddSingleton(_ => new CurrentItems());
		builder.Services.AddSingleton<AdminNavState>();
		builder.Services.AddScoped<DialogService>();
		builder.Services.AddScoped<NotificationService>();
		builder.Services.AddScoped<TooltipService>();
		builder.Services.AddMapster();

		return builder.Build();
	}
}
