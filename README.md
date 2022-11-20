# Stock Tracker

A program to display a variety of stock information for multiple stocks.

## Seed Data

This project comes with data to seed the database with so that when first running the project your database will already have stock information.  To turn this off you can update the `appsettings.json`

## API Data

This project is built with the intention to get stock information from an external API.  Currently it uses https://rapidapi.com/asepscareer/api/yahoo-finance97/ to get information.  If you would like to get information from this API you'll need to get an API key and then add it to the `appsettings.json`

## Testing

Run `dotnet test` to run the unit tests in this project
