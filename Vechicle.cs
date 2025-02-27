using System;

public class Vehicle
{
    public string VehicleName { get; set; }
    public string Maker { get; set; }
    public string Model { get; set; }
    public int YearOfManufacturing { get; set; }

    public void GetDetails()
    {
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Enter Vehicle Name: ");
            VehicleName = Console.ReadLine();

            if (string.IsNullOrEmpty(VehicleName) || ContainsNumbers(VehicleName))
            {
                Console.WriteLine("[red]Invalid input! Vehicle Name cannot be empty or contain numbers. Please enter a valid name.[/]");
            }
            else
            {
                validInput = true;
            }
        }

        validInput = false;
        while (!validInput)
        {
            Console.Write("Enter Vehicle Maker: ");
            Maker = Console.ReadLine();

            if (string.IsNullOrEmpty(Maker) || ContainsNumbers(Maker))
            {
                Console.WriteLine("[red]Invalid input! Maker cannot be empty or contain numbers. Please enter a valid maker.[/]");
            }
            else
            {
                validInput = true;
            }
        }

        validInput = false;
        while (!validInput)
        {
            Console.Write("Enter Vehicle Model: ");
            Model = Console.ReadLine();

            if (string.IsNullOrEmpty(Model) || ContainsNumbers(Model))
            {
                Console.WriteLine("[red]Invalid input! Model cannot be empty or contain numbers. Please enter a valid model.[/]");
            }
            else
            {
                validInput = true;
            }
        }

        validInput = false;
        while (!validInput)
        {
            Console.Write("Enter Vehicle Year of Manufacturing (e.g., 2025): ");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out int year);
            if (validInput)
            {
                YearOfManufacturing = year;
            }
            else
            {
                Console.WriteLine("[red]Invalid year input! Please enter a valid year.[/]");
            }
        }
    }

    private bool ContainsNumbers(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}
