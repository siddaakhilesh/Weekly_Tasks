using Spectre.Console;
using System;
using IVehicle;

public class CarDetails : Vehicle, IVehicleDetails
{
    public int Numberofseats { get; set; }
    public int CC{get; set;}
    public int Rent = Convert.ToInt32(100);

    // Implementing GetDetails from the interface
    public new void GetDetails()
    {
        base.GetDetails();
        
        Console.Write("Enter Number of Seats: ");
        Numberofseats = Convert.ToInt32(Console.ReadLine());
    }

    // Implementing DisplayDetails from the interface
    public void DisplayDetails()
    {
        var table = new Table();
        table.AddColumn("Property");
        table.AddColumn("Value");
        
        table.AddRow("Vehicle Name", VehicleName);
        table.AddRow("Maker", Maker);
        table.AddRow("Model", Model);
        table.AddRow("Year of Manufacturing", YearOfManufacturing.ToString());
        table.AddRow("Number of Seats", Numberofseats.ToString());
        table.AddRow("Horsepower of Bike", CC.ToString());
        table.AddRow("Rent Per Hour",Rent.ToString());

        
        AnsiConsole.Write(table);
    }
}
