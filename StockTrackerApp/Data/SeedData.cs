using StockTrackerApp.Models;

namespace StockTrackerApp.Data;

public static class SeedData {
    public static void CreateStockData(ApplicationDbContext db)
    {
        
        Stock stock1 = new Stock {    
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
        };
        db.Add(stock1);

        Stock stock2 = new Stock {
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
        };
        db.Add(stock2);

        Stock stock3 = new Stock {
            Symbol = "MA",
            LastUpdated = DateTime.UtcNow,
            Name = "MastercardIncorporated",
            Price = "302,37",
            PERatio = "30,635258",
            EvEbita = "23,863",
            FreeCashFlow = "9037124608",
            DebtToEquity = "231,252",
            EarningsGrowth = "0,125",
            RevenueGrowth = "0,214",
            Industry = "CreditServices",
        };
        db.Add(stock3);

        Stock stock4 = new Stock {
            Symbol = "T",
            LastUpdated = DateTime.UtcNow,
            Name = "AT&TInc.",
            Price = "17,1",
            PERatio = "6,2867646",
            EvEbita = "5,466",
            FreeCashFlow = "29654624256",
            DebtToEquity = "108,94",
            EarningsGrowth = "-0,023",
            RevenueGrowth = "-0,247",
            Industry = "TelecomServices",
        };
        db.Add(stock4);

        Stock stock5 = new Stock {
            Symbol = "ACN",
            LastUpdated = DateTime.UtcNow,
            Name = "Accentureplc",
            Price = "269,57",
            PERatio = "25,169935",
            EvEbita = "15,474",
            FreeCashFlow = "7736192000",
            DebtToEquity = "14,62",
            EarningsGrowth = "0,184",
            RevenueGrowth = "0,149",
            Industry = "InformationTechnologyServices",
        };
        db.Add(stock5);

        Stock stock6 = new Stock {
            Symbol = "CS",
            LastUpdated = DateTime.UtcNow,
            Name = "CreditSuisseGroup",
            Price = "4,72",
            PERatio = "Unknown",
            EvEbita = "Unknown",
            FreeCashFlow = "Unknown",
            DebtToEquity = "473,701",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "-0,298",
            Industry = "Banks—Diversified"
        };
        db.Add(stock6);

        Stock stock7 = new Stock {
            Symbol = "WMT",
            LastUpdated = DateTime.UtcNow,
            Name = "WalmartInc.",
            Price = "136,8",
            PERatio = "27,36",
            EvEbita = "12,516",
            FreeCashFlow = "301500000",
            DebtToEquity = "78,288",
            EarningsGrowth = "0,237",
            RevenueGrowth = "0,084",
            Industry = "DiscountStores",
        };
        db.Add(stock7);

        Stock stock8 = new Stock {
            Symbol = "SBUX",
            LastUpdated = DateTime.UtcNow,
            Name = "StarbucksCorporation",
            Price = "88,61",
            PERatio = "24,960564",
            EvEbita = "19,249",
            FreeCashFlow = "2472637440",
            DebtToEquity = "Unknown",
            EarningsGrowth = "-0,186",
            RevenueGrowth = "0,087",
            Industry = "Restaurants",
        };
        db.Add(stock8);

        Stock stock9 = new Stock {
            Symbol = "SHEL",
            LastUpdated = DateTime.UtcNow,
            Name = "RoyalDutchShellPLC",
            Price = "52,99",
            PERatio = "5,613348",
            EvEbita = "3,781",
            FreeCashFlow = "20765124608",
            DebtToEquity = "43,099",
            EarningsGrowth = "4,455",
            RevenueGrowth = "0,653",
            Industry = "Oil&GasIntegrated",
        };
        db.Add(stock9);

        Stock stock10 = new Stock {
            Symbol = "NFLX",
            LastUpdated = DateTime.UtcNow,
            Name = "Netflix,Inc.",
            Price = "289,57",
            PERatio = "24,395115",
            EvEbita = "23,113",
            FreeCashFlow = "16866191360",
            DebtToEquity = "80,047",
            EarningsGrowth = "-0,028",
            RevenueGrowth = "0,059",
            Industry = "Entertainment",
        };
        db.Add(stock10);

        Stock stock11 = new Stock {
            Symbol = "META",
            LastUpdated = DateTime.UtcNow,
            Name = "MetaPlatforms,Inc.",
            Price = "130,01",
            PERatio = "10,906878",
            EvEbita = "6,779",
            FreeCashFlow = "29296625664",
            DebtToEquity = "13,262",
            EarningsGrowth = "-0,319",
            RevenueGrowth = "-0,009",
            Industry = "InternetContent&Information",
        };
        db.Add(stock1);

        Stock stock12 = new Stock {
            Symbol = "GOOGL",
            LastUpdated = DateTime.UtcNow,
            Name = "AlphabetInc.",
            Price = "101,13",
            PERatio = "18,62431",
            EvEbita = "12,622",
            FreeCashFlow = "51070373888",
            DebtToEquity = "11,28",
            EarningsGrowth = "-0,113",
            RevenueGrowth = "0,126",
            Industry = "InternetContent&Information",
        };
        db.Add(stock12);

        Stock stock13 = new Stock {
            Symbol = "CRM",
            LastUpdated = DateTime.UtcNow,
            Name = "Salesforce,Inc.",
            Price = "160,17",
            PERatio = "302,20755",
            EvEbita = "65,297",
            FreeCashFlow = "9370250240",
            DebtToEquity = "23,826",
            EarningsGrowth = "-0,878",
            RevenueGrowth = "0,218",
            Industry = "Software—Application",
        };
        db.Add(stock13);

        Stock stock14 = new Stock {
            Symbol = "AMZN",
            LastUpdated = DateTime.UtcNow,
            Name = "Amazon.com,Inc.",
            Price = "119,32",
            PERatio = "103,75652",
            EvEbita = "24,942",
            FreeCashFlow = "-13441125376",
            DebtToEquity = "119,907",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "0,072",
            Industry = "InternetRetail",
        };
        db.Add(stock14);

        Stock stock15 = new Stock {
            Symbol = "VOD",
            LastUpdated = DateTime.UtcNow,
            Name = "VodafoneGroupPlc",
            Price = "11,31",
            PERatio = "16,157145",
            EvEbita = "7,046",
            FreeCashFlow = "10992749568",
            DebtToEquity = "126,82",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "0,032",
            Industry = "TelecomServices",
        };
        db.Add(stock15);

        Stock stock16 = new Stock {
            Symbol = "AAPL",
            LastUpdated = DateTime.UtcNow,
            Name = "AppleInc.",
            Price = "147,27",
            PERatio = "24,342148",
            EvEbita = "18,82",
            FreeCashFlow = "83344621568",
            DebtToEquity = "205,984",
            EarningsGrowth = "-0,077",
            RevenueGrowth = "0,019",
            Industry = "ConsumerElectronics",
        };
        db.Add(stock16);

        Stock stock17 = new Stock {
            Symbol = "F",
            LastUpdated = DateTime.UtcNow,
            Name = "FordMotorCompany",
            Price = "12,19",
            PERatio = "4,217993",
            EvEbita = "8,658",
            FreeCashFlow = "13603749888",
            DebtToEquity = "294,401",
            EarningsGrowth = "0,143",
            RevenueGrowth = "0,502",
            Industry = "AutoManufacturers",
        };
        db.Add(stock17);

        Stock stock18 = new Stock {
            Symbol = "GE",
            LastUpdated = DateTime.UtcNow,
            Name = "GeneralElectricCompany",
            Price = "72,82",
            PERatio = "Unknown",
            EvEbita = "12,63",
            FreeCashFlow = "40706998272",
            DebtToEquity = "97,769",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "0,022",
            Industry = "SpecialtyIndustrialMachinery",
        };
        db.Add(stock18);

        Stock stock20 = new Stock {
            Symbol = "V",
            LastUpdated = DateTime.UtcNow,
            Name = "VisaInc.",
            Price = "190,37",
            PERatio = "28,036818",
            EvEbita = "20,376",
            FreeCashFlow = "12285375488",
            DebtToEquity = "67,06",
            EarningsGrowth = "0,359",
            RevenueGrowth = "0,187",
            Industry = "CreditServices",
        };
        db.Add(stock20);

        Stock stock21 = new Stock {
            Symbol = "TSLA",
            LastUpdated = DateTime.UtcNow,
            Name = "Tesla,Inc.",
            Price = "214,44",
            PERatio = "74,71777",
            EvEbita = "47,111",
            FreeCashFlow = "5962749952",
            DebtToEquity = "17,699",
            EarningsGrowth = "0,907",
            RevenueGrowth = "0,416",
            Industry = "AutoManufacturers",
        };
        db.Add(stock21);

        Stock stock22 = new Stock {
            Symbol = "KO",
            LastUpdated = DateTime.UtcNow,
            Name = "Coca-ColaCompany(The)",
            Price = "55,96",
            PERatio = "25,436363",
            EvEbita = "20,789",
            FreeCashFlow = "7478499840",
            DebtToEquity = "172,628",
            EarningsGrowth = "-0,279",
            RevenueGrowth = "0,118",
            Industry = "Beverages—Non-Alcoholic",
        };
        db.Add(stock22);


        Stock stock23 = new Stock {
            Symbol = "MCD",
            LastUpdated = DateTime.UtcNow,
            Name = "McDonald'sCorporation",
            Price = "254,55",
            PERatio = "31,348522",
            EvEbita = "19,301",
            FreeCashFlow = "5407974912",
            DebtToEquity = "Unknown",
            EarningsGrowth = "-0,458",
            RevenueGrowth = "-0,029",
            Industry = "Restaurants",
        };
        db.Add(stock23);

        Stock stock24 = new Stock {
            Symbol = "DIS",
            LastUpdated = DateTime.UtcNow,
            Name = "WaltDisneyCompany(The)",
            Price = "102,04",
            PERatio = "Unknown",
            EvEbita = "22,763",
            FreeCashFlow = "6042124800",
            DebtToEquity = "50,016",
            EarningsGrowth = "-0,478",
            RevenueGrowth = "0,233",
            Industry = "Entertainment",
        };
        db.Add(stock24);

        Stock stock25 = new Stock {
            Symbol = "BKNG",
            LastUpdated = DateTime.UtcNow,
            Name = "BookingHoldingsInc.CommonSt",
            Price = "1822,79",
            PERatio = "47,382114",
            EvEbita = "15,624",
            FreeCashFlow = "6456374784",
            DebtToEquity = "244,778",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "0,988",
            Industry = "TravelServices",
        };
        db.Add(stock25);

        Stock stock26 = new Stock {
            Symbol = "PFE",
            LastUpdated = DateTime.UtcNow,
            Name = "Pfizer,Inc.",
            Price = "44,95",
            PERatio = "26,332748",
            EvEbita = "6,878",
            FreeCashFlow = "Unknown",
            DebtToEquity = "44,072",
            EarningsGrowth = "0,764",
            RevenueGrowth = "0,462",
            Industry = "DrugManufacturers—General",
        };
        db.Add(stock26);

        Stock stock27 = new Stock {
            Symbol = "JNJ",
            LastUpdated = DateTime.UtcNow,
            Name = "Johnson&Johnson",
            Price = "168,71",
            PERatio = "23,497215",
            EvEbita = "14,017",
            FreeCashFlow = "Unknown",
            DebtToEquity = "42,69",
            EarningsGrowth = "0,223",
            RevenueGrowth = "0,019",
            Industry = "DrugManufacturers—General",
        };
        db.Add(stock27);

        Stock stock28 = new Stock {
            Symbol = "KHC",
            LastUpdated = DateTime.UtcNow,
            Name = "TheKraftHeinzCompany",
            Price = "35,21",
            PERatio = "28,626015",
            EvEbita = "10,462",
            FreeCashFlow = "2859749888",
            DebtToEquity = "43,114",
            EarningsGrowth = "Unknown",
            RevenueGrowth = "-0,009",
            Industry = "PackagedFoods",
        };
        db.Add(stock28);

        db.SaveChanges();
    }
}