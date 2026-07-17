using Microsoft.EntityFrameworkCore;
using RetailInventory;

Task1_UnderstandingOrm.Run();

using var context = new InventoryContext();
Task2_SetupDbContext.Run(context);
Task4_InsertInitialData.Run(context);
Task5_RetrieveData.Run(context);
Task3_EfCoreCliMigrations.Run();
