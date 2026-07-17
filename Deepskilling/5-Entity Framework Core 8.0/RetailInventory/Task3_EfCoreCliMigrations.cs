namespace RetailInventory;

public static class Task3_EfCoreCliMigrations
{
    public static void Run()
    {
        Console.WriteLine("Task 3: Using EF Core CLI to Create and Apply Migrations");
        Console.WriteLine("This task demonstrates the command-line steps needed to manage database schema.");
        Console.WriteLine("Example commands:");
        Console.WriteLine("  dotnet ef migrations add InitialCreate");
        Console.WriteLine("  dotnet ef database update");
        Console.WriteLine("The project uses SQLite and the InventoryContext with a local database file.\n");
    }
}
