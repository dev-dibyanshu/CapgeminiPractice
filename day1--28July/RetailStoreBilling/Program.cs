using System;

Console.Write("Enter Item Price: ");
string? priceInput = Console.ReadLine();

if (!decimal.TryParse(priceInput, out decimal price))
{
    Console.WriteLine("Invalid price entered.");
    return;
}

if (price < 0)
{
    Console.WriteLine("Price cannot be negative.");
    return;
}

Console.Write("Enter Quantity: ");
string? quantityInput = Console.ReadLine();

if (!int.TryParse(quantityInput, out int quantity))
{
    Console.WriteLine("Invalid quantity entered.");
    return;
}

if (quantity < 0)
{
    Console.WriteLine("Quantity cannot be negative.");
    return;
}

Console.Write("Enter Discount Percentage: ");
string? discountInput = Console.ReadLine();

if (!decimal.TryParse(discountInput, out decimal discount))
{
    Console.WriteLine("Invalid discount entered.");
    return;
}

if (discount < 0)
{
    Console.WriteLine("Discount cannot be negative.");
    return;
}

// Calculations
decimal subtotal = price * quantity;
decimal discountAmount = subtotal * discount / 100;
decimal finalAmount = subtotal - discountAmount;

// Round to 2 decimal places
subtotal = Math.Round(subtotal, 2);
discountAmount = Math.Round(discountAmount, 2);
finalAmount = Math.Round(finalAmount, 2);

// Display Results
Console.WriteLine("\n------ Bill Summary ------");
Console.WriteLine($"Subtotal        : {subtotal}");
Console.WriteLine($"Discount Amount : {discountAmount}");
Console.WriteLine($"Final Amount    : {finalAmount}");