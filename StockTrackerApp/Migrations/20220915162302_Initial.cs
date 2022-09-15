using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockTrackerApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPost",
                columns: table => new
                {
                    Symbol = table.Column<string>(type: "text", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false),
                    PERatio = table.Column<string>(type: "text", nullable: false),
                    EvEbita = table.Column<string>(type: "text", nullable: false),
                    FreeCashFlow = table.Column<string>(type: "text", nullable: false),
                    DebtToEquity = table.Column<string>(type: "text", nullable: false),
                    EarningsGrowth = table.Column<string>(type: "text", nullable: false),
                    RevenueGrowth = table.Column<string>(type: "text", nullable: false),
                    Industry = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPost", x => x.Symbol);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPost");
        }
    }
}
