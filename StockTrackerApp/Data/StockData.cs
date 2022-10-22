using StockTrackerApp.Api;
using StockTrackerApp.Constants;
using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public static class StockData {
    public static void UpdateStockData()
    {
        List<string> symbols = StockSymbols.Symbols;
        ApiInterface apiInterface = new ApiInterface();

        foreach(string symbol in symbols)
        {
            Task<ApiResponseBody> result = apiInterface.GetStockInfo(symbol);
            result.Wait();
            ApiResponseBody body = result.Result;
            Console.WriteLine("---------------------------");
            Console.WriteLine(body.status);
            Console.WriteLine(body.message);
            Console.WriteLine(body.data.shortName);
            Console.WriteLine(body.data.currentPrice);
            Console.WriteLine(body.data.trailingPE);
            Console.WriteLine(body.data.enterpriseToEbitda);
            Console.WriteLine(body.data.freeCashflow);
            Console.WriteLine(body.data.debtToEquity);
            Console.WriteLine(body.data.earningsGrowth);
            Console.WriteLine(body.data.revenueGrowth);
            Console.WriteLine(body.data.industry);
            Console.WriteLine("---------------------------");
        }
    }
}