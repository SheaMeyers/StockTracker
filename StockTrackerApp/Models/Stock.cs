using System.ComponentModel.DataAnnotations;
namespace StockTrackerApp.Models;

public class Stock {
    
    [Key]
    public string Symbol { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string PERatio { get; set; }
    public string EvEbita { get; set; }
    public string FreeCashFlow { get; set; }
    public string DebtToEquity { get; set; }
    public string EarningsGrowth { get; set; }
    public string RevenueGrowth { get; set; }
    public string Industry { get; set; }
}
