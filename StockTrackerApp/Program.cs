using Microsoft.EntityFrameworkCore;
using StockTrackerApp.Models;
using StockTrackerApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

ApiConfig.Domain = builder.Configuration.GetValue<string>("ApiConfig:Domain");
ApiConfig.ApiKey = builder.Configuration.GetValue<string>("ApiConfig:ApiKey");

var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();

if (builder.Configuration.GetValue<bool>("CallApi")) {
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        StockData.UpdateStockData(db);
    }
}

if (builder.Configuration.GetValue<bool>("SeedData")) {
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        SeedData.CreateStockData(db);
    }
}

app.Run();
