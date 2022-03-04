using Gest.Core.Data;
using Gest.UI.Extensions;
using Gest.UI.Models;
using Gest.UI.Shared;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GestDbContext>(options => options.UseSqlite("Data Source=app.db"));
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton(_ => new CurrentItems());
builder.Services.AddSingleton<AdminNavState>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddMapster();

var app = builder.Build();

using var serviceScope = app.Services.CreateAsyncScope();
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
