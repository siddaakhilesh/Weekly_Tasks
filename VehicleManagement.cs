using System;
using System.Collections.Generic;
using IVehicle;

public class VehicleManagement
{
    // Created list to store all vehicle details both cars and bikes
    private List<IVehicleDetails> vehicles = new List<IVehicleDetails>();

    // adding a vehicle to the list
    public void AddVehicle(IVehicleDetails vehicle)
    {
        vehicles.Add(vehicle);
    }

    // Method to display all vehicle details
    public void DisplayAllVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles available to display.");
            return;
        }

        Console.WriteLine("\nDisplaying All Vehicle Details:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("------------------------------------------------");
        }
    }

    //Method to display car details
    public void DisplayCarDetails()
    {
        bool carFound = false;

        foreach (var vehicle in vehicles)
        {
            if (vehicle is CarDetails car)
            {
                if (!carFound)
                {
                    Console.WriteLine("\nDisplaying Car Details:");
                    carFound = true;
                }
                car.DisplayDetails();
                Console.WriteLine("------------------------------------------------");
            }
        }

        if (!carFound)
        {
            Console.WriteLine("No cars available to display.");
        }
    }

    //method to display bike details
    public void DisplayBikeDetails()
    {
        bool bikeFound = false;

        foreach (var vehicle in vehicles)
        {
            if (vehicle is BikeDetails bike)
            {
                if (!bikeFound)
                {
                    Console.WriteLine("\nDisplaying Bike Details:");
                    bikeFound = true;
                }
                bike.DisplayDetails();
                Console.WriteLine("------------------------------------------------");
            }
        }

        if (!bikeFound)
        {
            Console.WriteLine("No bikes available to display.");
        }
    }
}
