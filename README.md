# aspnet-proj-source

This will be a DOTNET + Angular project to build a Social App web api.
It will use .NET 8.0 ASP.NET framework API w/ C# to build the back-end,
and Angular v18 for the front-end.

## Summary
Projects inside the [SocialApp.sln](./SocialApp.sln) solution file:
- [API](./API/API.csproj) - ASP.NET Core Web API project

## Requirements
- Dotnet CLI
- Angular

## Installation (API)
Run the following commands to install the project dependencies:
```bash
dotnet restore
```

## Usage (API)

Run the following command to start the API:
```bash
cd API; dotnet run -lp api
```
This will start the API on `http://localhost:5000` and `https://localhost:5001`.
To test the API, run the following command(s):
```bash
curl -X GET "http://localhost:5000/weatherforecast" -H  "accept: application/json"
# or
curlie localhost:5000/weatherforecast --proto http
# or
wget -qO- http://localhost:5000/weatherforecast
```