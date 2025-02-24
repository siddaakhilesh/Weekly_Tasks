using System;

public class Vehicle
{
    public string VehicleName { get; set; }
    public string Maker { get; set; }
    public string Model { get; set; }
    public int YearOfManufacturing { get; set; }

    // Method to get details from the user
    public void GetDetails()
    {
        Console.Write("Enter Vehicle Name: ");
        VehicleName = Console.ReadLine();
        
        Console.Write("Enter Vehicle Maker: ");
        Maker = Console.ReadLine();
        
        Console.Write("Enter Vehicle Model: ");
        Model = Console.ReadLine();
        
        Console.Write("Enter Vehicle Year of Manufacturing: ");
        YearOfManufacturing = Convert.ToInt32(Console.ReadLine());
    }
}
