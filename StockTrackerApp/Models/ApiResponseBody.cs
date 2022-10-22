namespace StockTrackerApp.Models;

public class Data {
    public string? shortName { get; set; }
    public float? currentPrice { get; set; }
    public float? trailingPE { get; set; }
    public float? enterpriseToEbitda { get; set; }
    public long? freeCashflow { get; set; }
    public float? debtToEquity { get; set; }
    public float? earningsGrowth { get; set; }
    public float? revenueGrowth { get; set; }
    public string? industry { get; set; }
}

public class ApiResponseBody {
    public int status { get; set; }
    public string message { get; set; }
    public Data data { get; set; }
}
