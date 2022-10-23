using StockTrackerApp.Api;
using StockTrackerApp.Constants;
using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public static class StockData {
    public static void UpdateStockData(ApplicationDbContext db)
    {
        List<string> symbols = StockSymbols.Symbols;
        ApiInterface apiInterface = new ApiInterface();

        foreach(string symbol in symbols)
        {
            Console.WriteLine("Getting stock info for " + symbol);
            Task<ApiResponseBody> result = apiInterface.GetStockInfo(symbol);
            result.Wait();
            ApiResponseBody body = result.Result;

            Stock stock;
            bool newStock = false;
            try {
                stock = db.Stock.Single(s => s.Symbol == symbol);
            } catch {
                // If not found just create a new one now
                stock = new Stock();
                stock.Symbol = symbol;
                newStock = true;
            }

            string newName = !String.IsNullOrWhiteSpace(body.data.shortName) ? body.data.shortName : stock.Name;
            stock.Name = !String.IsNullOrWhiteSpace(newName) ? newName : "Unknown";
            
            string newPrice = body.data.currentPrice != null ? body.data.currentPrice.ToString() : stock.Price;
            stock.Price = !String.IsNullOrWhiteSpace(newPrice) ? newPrice : "Unknown";

            string newPERatio = body.data.trailingPE != null ? body.data.trailingPE.ToString() : stock.PERatio;
            stock.PERatio = !String.IsNullOrWhiteSpace(newPERatio) ? newPERatio : "Unknown";
            
            string newEvEbita = body.data.enterpriseToEbitda != null ? body.data.enterpriseToEbitda.ToString() : stock.EvEbita;
            stock.EvEbita = !String.IsNullOrWhiteSpace(newEvEbita) ? newEvEbita : "Unknown";
            
            string newFreeCashFlow = body.data.freeCashflow != null ? body.data.freeCashflow.ToString() : stock.FreeCashFlow;
            stock.FreeCashFlow = !String.IsNullOrWhiteSpace(newFreeCashFlow) ? newFreeCashFlow : "Unknown";
            
            string newDebtToEquity = body.data.debtToEquity != null ? body.data.debtToEquity.ToString() : stock.DebtToEquity;
            stock.DebtToEquity = !String.IsNullOrWhiteSpace(newDebtToEquity) ? newDebtToEquity : "Unknown";
            
            string newEarningGrowth = body.data.earningsGrowth != null ? body.data.earningsGrowth.ToString() : stock.EarningsGrowth;
            stock.EarningsGrowth = !String.IsNullOrWhiteSpace(newEarningGrowth) ? newEarningGrowth : "Unknown";
            
            string revenueGrowth = body.data.revenueGrowth != null ? body.data.revenueGrowth.ToString() : stock.RevenueGrowth;
            stock.RevenueGrowth = !String.IsNullOrWhiteSpace(revenueGrowth) ? revenueGrowth : "Unknown";
            
            string industry = body.data.industry != null ? body.data.industry.ToString() : stock.Industry;
            stock.Industry = !String.IsNullOrWhiteSpace(industry) ? industry : "Unknown";

            stock.LastUpdated = DateTime.UtcNow;

            if (newStock) {
                db.Add(stock);
            } else {
                db.Update(stock);
            }
            Console.WriteLine("Finished getting stock info for " + symbol);
            Thread.Sleep(5000);
        }

        db.SaveChanges();
    }
}