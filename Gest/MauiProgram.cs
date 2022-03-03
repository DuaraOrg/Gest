using Microsoft.AspNetCore.Components.WebView.Maui;
using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Gest.UI.Models;
using Gest.UI.Shared;
using Radzen;

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
		builder.Services.AddDbContext<GestDbContext>(opt => opt.UseSqlite(localConString),ServiceLifetime.Singleton);
		builder.Services.AddBlazorWebView();

		builder.Services.AddSingleton(_ => new CurrentItems());
		builder.Services.AddSingleton<AdminNavState>();
		builder.Services.AddScoped<DialogService>();
		builder.Services.AddScoped<NotificationService>();
		builder.Services.AddScoped<TooltipService>();

		return builder.Build();
	}
}
