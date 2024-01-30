### Mini Project: Board Game Store Inventory Management

**Project Overview**:
- Create a simple inventory management system for a Board Game Store.
- Users can interact with a menu to look up items, view all items, or add items to the inventory.

**Step 1: Base Class and Derived Classes**
- Create a base class `InventoryItem` with properties: `Id`, `Name`, `Description`, `Price`, and `Quantity`.
- Create derived classes for different types of board games. Example:
  - `StrategyGame` with additional properties like `MinAge`, `MaxPlayers`.
  - `FamilyGame` with properties like `RecommendedAge`, `PlayTime`.
  - `CardGame` with properties like `DeckSize`, `Genre`.
  - `BoardGameAccessory` with properties like `Type` (dice, figures, etc.), `Material`.

**Step 2: Inventory Management**
- Since we're not using lists or arrays, create individual variables for each inventory item. Make at least three. This is a limitation and not practical for a real-world application but will suffice for this exercise. If you know how to use lists, go ahead and use a list.

**Step 3: User Interaction**
- Implement a simple text-based menu system that allows the user to:
  - View all items (display name and type).
  - Look up an item by ID and view its details.
  - Add an item to the inventory (by creating a new object and assigning values).

**Step 4: Item Details and Adding Items**
- For displaying item details, implement a method in the `InventoryItem` class that displays common properties and override it in derived classes to include specific properties.
- For adding items, create a method that takes user input and creates an object of the appropriate derived class.

**Step 5: Constructors and Methods**
- Create constructors for the base class and each derived class.
- Implement methods for each user interaction: viewing items, looking up details, and adding items.

**Step 6: Basic User Interface**
- Use a loop with a switch or if-else statements for the menu selection.
- Provide options to the user and handle their input to call the appropriate methods.

**Step 7: Error Handling**
- Add basic error handling for user inputs (like invalid IDs or incorrect data types).

**Example Code Structure**:
```csharp
abstract class InventoryItem
{
    // Base properties
}

class StrategyGame : InventoryItem
{
    // Specific properties
}

class FamilyGame : InventoryItem
{
    // Specific properties
}

class CardGame : InventoryItem
{
    // Specific properties
}

class BoardGameStore
{
    // Main method with menu system
    // Methods for displaying items, looking up details, adding items
}

class Program
{
    static void Main(string[] args)
    {
        BoardGameStore store = new BoardGameStore();
        store.Run(); // Run the store's menu system
    }
}
```

