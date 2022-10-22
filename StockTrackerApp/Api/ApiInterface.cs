using Microsoft.Extensions.Options;
using StockTrackerApp.Models;

namespace StockTrackerApp.Api;

public class ApiInterface {

    public async Task<ApiResponseBody> GetStockInfo(string symbol)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"https://{ApiConfig.Domain}/stock-info"),
            Headers =
            {
                { "X-RapidAPI-Key", ApiConfig.ApiKey },
                { "X-RapidAPI-Host", ApiConfig.Domain },
            },
            Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "symbol", symbol },
            }),
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadFromJsonAsync<ApiResponseBody>();
            return body;
        }
    }
}
