// See https://aka.ms/new-console-template for more information
using InventoryManagement;

InventoryManagementMain inventoryManagement = new InventoryManagementMain();
inventoryManagement.ReadData(@"D:\bz\Fellowship\OOPS\InventoryManagement\InventoryData.json");
Console.ReadKey();