### Mini Project: Advanced Garden Supplies Store Inventory Management

**Project Overview**:
- Create an inventory management system for a Garden Supplies Store.
- Users interact with a menu to perform actions like viewing items, searching for items, adding items, and generating invoices.

**Step 1: Base Class and Derived Classes**
- Base class `InventoryItem` with properties: `Id`, `Name`, `Description`, `Price`, `Quantity`.
- Derived classes for various garden supplies. Examples:
  - `PlantItem` with additional properties like `PlantType`, `SunRequirement`.
  - `ToolItem` with properties like `ToolType`, `Material`.
  - `FertilizerItem` with properties like `Composition`, `PackageSize`.
  - `DecorItem` with properties like `Material`, `OutdoorIndoor`.

**Step 2: Collection for Inventory Management**
- Use a `List<InventoryItem>` to store and manage the inventory items.

**Step 3: File I/O for Inventory Initialization**
- Read inventory data from a file to populate the `List<InventoryItem>`.
- The file format can be a simple text or csv format for easy parsing.
- For example:

```
Id,Type,Name,Description,Price,Quantity,AdditionalProperties
1,Plant,Rose Bush,Beautiful red roses,19.99,15,PlantType=Flower;SunRequirement=FullSun
2,Tool,Gardening Shovel,Heavy-duty shovel,29.99,20,ToolType=Digging;Material=Steel
3,Fertilizer,Rose Fertilizer,Specialized rose plant food,15.99,50,Composition=NPK 10-10-10;PackageSize=2kg
4,Decor,Garden Gnome,Hand-painted gnome,24.99,30,Material=Ceramic;OutdoorIndoor=Outdoor
5,Plant,Tulip Bulbs,Mixed color tulip bulbs,9.99,40,PlantType=Bulb;SunRequirement=PartialShade
6,Tool,Pruning Shears,Comfort grip pruning shears,14.99,25,ToolType=Cutting;Material=Stainless Steel
7,Fertilizer,All-Purpose Fertilizer,General use fertilizer,12.99,30,Composition=NPK 20-20-20;PackageSize=1.5kg
8,Decor,Water Fountain,Outdoor water fountain,199.99,5,Material=Stone;OutdoorIndoor=Outdoor
```

**Step 4: LINQ for Advanced Queries**
- Use LINQ to enable advanced search functionalities like finding items by name, price range, type, etc.

**Step 5: User Interaction with Enhanced Menu**
- Implement an enhanced menu system to allow users to:
  - View all items.
  - Search for items by various criteria using LINQ.
  - Add items to the inventory.
  - Generate and save an invoice as a file for purchased items.

**Step 6: Constructors, Methods, and File Writing**
- Create constructors for the base class and derived classes.
- Implement methods for file reading, displaying items, searching items, adding items, and invoice generation.
- Use file writing to create invoice files for purchases.

**Step 7: Error Handling and Validation**
- Implement robust error handling and input validation.

**Example Code Structure**:
```csharp
abstract class InventoryItem
{
    // Base properties and methods
}

class PlantItem : InventoryItem
{
    // Specific properties
}

class ToolItem : InventoryItem
{
    // Specific properties
}

class GardenSuppliesStore
{
    private List<InventoryItem> inventory;

    public GardenSuppliesStore()
    {
        // Initialize inventory from file
    }

    public void Run()
    {
        // Main menu system
    }

    // Methods for displaying items, searching, adding items, and generating invoices
}

class Program
{
    static void Main(string[] args)
    {
        GardenSuppliesStore store = new GardenSuppliesStore();
        store.Run(); // Run the store's menu system
    }
}
```
