# Stock Tracker

A program to display a variety of stock information for multiple stocks.

## Quickstart

Use the steps below when setting up this project for the first time. These steps are intended to allow you to quickly run the project.

1. Clone the repository
2. Create the database and database user as specified in the `appsettings.json`
3. Go into the `StockTrackerApp` directory and run `dotnet ef database update` in order to setup the database
4. Run `dotnet run` to start the project
5. Go to `https://localhost:7177`

## Seed Data

This project comes with data to seed the database with so that when first running the project your database will already have stock information.  To turn this off you can update the `SeedData` attribute of `appsettings.json`

## API Data

This project is built with the intention to get stock information from an external API.  Currently it uses https://rapidapi.com/asepscareer/api/yahoo-finance97/ to get information.  If you would like to get information from this API you'll need to get an API key and then add it to the `ApiKey` attribute of `appsettings.json`

## Testing

Run `dotnet test` to run the unit tests in this project
