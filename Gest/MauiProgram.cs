using Microsoft.AspNetCore.Components.WebView.Maui;
using Gest.Data;
using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;

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
		builder.Services.AddDbContext<GestDbContext>(opt => opt.UseSqlite(localConString));
		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
