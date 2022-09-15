using Microsoft.EntityFrameworkCore;
using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    public DbSet<Stock> Stock { get; set; }
}