using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockTrackerApp.Data;
using StockTrackerApp.Models;
using Xunit;


public class IndexPageTests : IClassFixture<TestDatabaseFixture>
{
    public IndexPageTests(TestDatabaseFixture fixture) => Fixture = fixture;

    public TestDatabaseFixture Fixture { get; }

    [Fact]
    public void FirstTest()
    {
        var context = Fixture.CreateContext();

        context.Add(new Stock {
            Symbol = "BCS",
            LastUpdated = DateTime.UtcNow,
            Name = "BarclaysPLC",
            Price = "6,66",
            PERatio = "4,861314",
            EvEbita = "Unknown",
            FreeCashFlow = "Unknown",
            DebtToEquity = "Unknown",
            EarningsGrowth = "-0,462",
            RevenueGrowth = "0,048",
            Industry = "Banks—Diversified",
        });
        context.Add(new Stock {    
            Symbol = "BLK",
            LastUpdated = DateTime.UtcNow,
            Name = "BlackRock,Inc.",
            Price = "597,26",
            PERatio = "16,453444",
            EvEbita = "12,6",
            FreeCashFlow = "Unknown",
            DebtToEquity = "22,073",
            EarningsGrowth = "-0,151",
            RevenueGrowth = "-0,146",
            Industry = "AssetManagement",
        });
        context.SaveChanges();

        Assert.True(true);
    }
}