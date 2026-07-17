# EF Core 8.0 Hands-on Lab

This folder contains a sample EF Core 8.0 console application for a retail inventory system.

## Included labs

- Lab 1: Understanding ORM with a Retail Inventory System
- Lab 2: Setting Up the Database Context for a Retail Store
- Lab 3: Using EF Core CLI to Create and Apply Migrations
- Lab 4: Inserting Initial Data into the Database
- Lab 5: Retrieving Data from the Database
- Lab 6: Updating and Deleting Records
- Lab 7: Writing Queries with LINQ

## Project structure

- `RetailInventory/` - sample console app
- `RetailInventory/InventoryContext.cs` - EF Core `DbContext`
- `RetailInventory/Models/` - entity classes for `Product`, `Category`, and `Store`
- `RetailInventory/DbInitializer.cs` - seed data initializer
- `RetailInventory/RetailInventory.csproj` - project file with EF Core and SQLite packages

## How to run

```powershell
cd "Deepskilling\5-Entity Framework Core 8.0\RetailInventory"
dotnet run
```

## Notes

- Uses SQLite database `RetailInventory.db` in the project directory.
- The project is built for .NET 8.
