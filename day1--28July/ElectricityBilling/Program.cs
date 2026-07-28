using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Electricity Billing System =====");
        Console.WriteLine("1. Residential Customer");
        Console.WriteLine("2. Commercial Customer");

        string? choice;
        while (true)
        {
            Console.Write("Enter Customer Type (1 or 2): ");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2")
            {
                break;
            }

           Console.WriteLine("Invalid Customer Type! Please enter 1 or 2.\n");
        }

        double units;
        double rate;
        double fixedCharges;

        // Units
        while (true)
        {
            Console.Write("Enter Units Consumed: ");

            if (double.TryParse(Console.ReadLine(), out units) && units >= 0)
            {
                break;
            }

            Console.WriteLine("Invalid Units! Please enter a valid positive number.");
        }

        // Rate
        while (true)
        {
            Console.Write("Enter Rate Per Unit: ");

            if (double.TryParse(Console.ReadLine(), out rate) && rate >= 0)
            {
                break;
            }

            Console.WriteLine("Invalid Rate! Please enter a valid positive number.");
        }

        // Fixed Charges
        while (true)
        {
            Console.Write("Enter Fixed Charges: ");

            if (double.TryParse(Console.ReadLine(), out fixedCharges) && fixedCharges >= 0)
            {
                break;
            }

            Console.WriteLine("Invalid Fixed Charges! Please enter a valid positive number.");
        }

        IBillCalculator calculator;

        if (choice == "1")
        {
            calculator = new ResidentialCustomer();
        }
        else if (choice == "2")
        {
            calculator = new CommercialCustomer();
        }
        else
        {
            Console.WriteLine("Invalid Customer Type!");
            return;
        }

        double bill = calculator.CalculateBill(units, rate, fixedCharges);

        Console.WriteLine("\n========== BILL ==========");
        Console.WriteLine($"Customer Type : {(choice == "1" ? "Residential" : "Commercial")}");
        Console.WriteLine($"Units         : {units}");
        Console.WriteLine($"Rate          : {rate}");
        Console.WriteLine($"Fixed Charges : {fixedCharges}");
        Console.WriteLine($"Total Bill    : {Math.Round(bill, 2)}");
    }
}