using Spectre.Console;
using System;

class Program
{
    static void Main()
    {
        VehicleManagement vehicleManagement = new VehicleManagement();

        while (true)
        {
            // Create a table with options
            var table = new Table();
            table.AddColumn("Option");
            table.AddColumn("Description");

            // Add rows with the menu options
            table.AddRow("[bold yellow]1[/]", "[green]Add Car[/]");
            table.AddRow("[bold yellow]2[/]", "[green]Add Bike[/]");
            table.AddRow("[bold yellow]3[/]", "[cyan]Display All Vehicles[/]");
            table.AddRow("[bold yellow]4[/]", "[cyan]Display Only Cars[/]");
            table.AddRow("[bold yellow]5[/]", "[cyan]Display Only Bikes[/]");
            table.AddRow("[bold yellow]6[/]", "[red]Exit[/]");

            // Wrap the table in a panel
            var panel = new Panel(table)
            {
                Header = new PanelHeader("[bold yellow]Vehicle Rental Management[/]")
            };

            // Render the panel with the table
            AnsiConsole.Write(panel);

            // Get user input
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Process the user choice
            if (choice == 1)
            {
                CarDetails car = new CarDetails();
                car.GetDetails();
                vehicleManagement.AddVehicle(car);
                Console.WriteLine("Car added successfully.[/]");
            }
            else if (choice == 2)
            {
                BikeDetails bike = new BikeDetails();
                bike.GetDetails();
                vehicleManagement.AddVehicle(bike);
                Console.WriteLine("Bike added successfully.[/]");
            }
            else if (choice == 3)
            {
                vehicleManagement.DisplayAllVehicles();
            }
            else if (choice == 4)
            {
                vehicleManagement.DisplayCarDetails();
            }
            else if (choice == 5)
            {
                vehicleManagement.DisplayBikeDetails();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Exiting the system.[/]");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }
        }
    }
}
