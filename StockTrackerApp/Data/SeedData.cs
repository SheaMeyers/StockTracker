using StockTrackerApp.Api;
using StockTrackerApp.Constants;
using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public static class SeedData {
    public static void CreateStockData(ApplicationDbContext db)
    {
        Stock stock = new Stock { 
            Symbol = "ACB",
            LastUpdated = DateTime.UtcNow,
            Name = "Aurora Cannabis Inc.",
            Price = "1,1",
            PERatio = "Unknown",
            EvEbita = "-1,096",
            FreeCashFlow = "-139917120",
            DebtToEquity = "40,687",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "-0,084",
            Industry = "Drug Manufacturers—Specialty & Generic",
        };
        db.Add(stock);

        db.SaveChanges();
    }
}