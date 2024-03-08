using System;

public class InventoryItem
{
    // Properties
    private string name;
    private int id;
    private double price;
    private int quantity;

    // Constructor
    public InventoryItem(string name, int id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    // Methods
    public void UpdatePrice(double newPrice)
    {
        this.price = newPrice;
    }

    public void RestockItem(int additionalQuantity)
    {
        this.quantity += additionalQuantity;
    }

    public void SellItem(int quantitySold)
    {
        if (quantitySold <= this.quantity)
        {
            this.quantity -= quantitySold;
        }
        else
        {
            Console.WriteLine("Insufficient quantity in stock.");
        }
    }

    public bool IsInStock()
    {
        return this.quantity > 0;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Price: {price:C}");
        Console.WriteLine($"Quantity: {quantity}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Widget", 1, 15.99, 30);
        InventoryItem item2 = new InventoryItem("Gadget", 2, 21.49, 25);

        // Demonstrate methods
        Console.WriteLine("Initial details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell item
        item1.SellItem(5);
        Console.WriteLine("\nAfter selling 5 items of item1:");
        item1.PrintDetails();

        // Update price
        item1.UpdatePrice(18.99);
        Console.WriteLine("\nAfter updating price of item1:");
        item1.PrintDetails();

        // Restock item
        item2.RestockItem(5);
        Console.WriteLine("\nAfter restocking item2:");
        item2.PrintDetails();

        // Check if item is in stock
        Console.WriteLine("\nIs item2 in stock? " + item2.IsInStock());
    }
}
