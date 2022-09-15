using Microsoft.AspNetCore.Mvc.RazorPages;
using StockTrackerApp.Data;
using StockTrackerApp.Models;

namespace StockTrackerApp.Pages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _db;
    public IEnumerable<Stock> Stocks { get; set; }

    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        Stocks = _db.Stock;
    }
}
