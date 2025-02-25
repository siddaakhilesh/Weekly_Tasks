using Spectre.Console;
using System;
using IVehicle;
public class BikeDetails : Vehicle, IVehicleDetails
{
    public string BikeType { get; set; }

    public int CarRent = Convert.ToInt32(200);

    public void GetDetails()
    {
        base.GetDetails();
        
        Console.Write("Enter Bike Type (e.g., Cruiser, Sports): ");
        BikeType = Console.ReadLine();
        
    }
    public void DisplayDetails()
    {
        var table = new Table();
        table.AddColumn("Property");
        table.AddColumn("Value");
        
        table.AddRow("Vehicle Name", VehicleName);
        table.AddRow("Maker", Maker);
        table.AddRow("Model", Model);
        table.AddRow("Year of Manufacturing", YearOfManufacturing.ToString());
        table.AddRow("Bike Type", BikeType);
        table.AddRow("Rent per Hour", CarRent.ToString());
        
        AnsiConsole.Write(table);
    }
}
