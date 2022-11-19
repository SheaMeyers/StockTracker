using Microsoft.EntityFrameworkCore;
using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Stock> Stock { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}