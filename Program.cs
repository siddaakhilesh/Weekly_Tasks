using Spectre.Console;
using System;

class Program
{
    static void Main()
    {
        VehicleManagement vehicleManagement = new VehicleManagement();

        while (true)
        {
            var table = new Table();
            table.AddColumn("Option");
            table.AddColumn("Description");

            table.AddRow("[bold yellow]1[/]", "[green]Add Car[/]");
            table.AddRow("[bold yellow]2[/]", "[green]Add Bike[/]");
            table.AddRow("[bold yellow]3[/]", "[cyan]Display All Vehicles[/]");
            table.AddRow("[bold yellow]4[/]", "[cyan]Display Only Cars[/]");
            table.AddRow("[bold yellow]5[/]", "[cyan]Display Only Bikes[/]");
            table.AddRow("[bold yellow]6[/]", "[red]Exit[/]");

            var panel = new Panel(table)
            {
                Header = new PanelHeader("[bold yellow]Vehicle Rental Management[/]")
            };

            AnsiConsole.Write(panel);

            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("[red]Invalid choice! Please enter a number between 1 and 6.[/]");
                Console.Write("Enter your choice: ");
            }

            switch (choice)
            {
                case 1:
                    CarDetails car = new CarDetails();
                    car.GetDetails();
                    vehicleManagement.AddVehicle(car);
                    Console.WriteLine("[green]Car added successfully.[/]");
                    break;
                
                case 2:
                    BikeDetails bike = new BikeDetails();
                    bike.GetDetails();
                    vehicleManagement.AddVehicle(bike);
                    Console.WriteLine("[green]Bike added successfully.[/]");
                    break;

                case 3:
                    vehicleManagement.DisplayAllVehicles();
                    break;

                case 4:
                    vehicleManagement.DisplayCarDetails();
                    break;

                case 5:
                    vehicleManagement.DisplayBikeDetails();
                    break;

                case 6:
                    Console.WriteLine("[red]Exiting the system.[/]");
                    return;

                default:
                    Console.WriteLine("[red]Invalid choice! Please try again.[/]");
                    break;
            }
        }
    }
}
