using System;
using System.Collections.Generic;
using System.Linq;

public class RentalAgency
{
    private List<Vehicle> fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
    }

    public bool RemoveVehicle(string model)
    {
        var vehicle = fleet.FirstOrDefault(v => v.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        if (vehicle != null)
        {
            fleet.Remove(vehicle);
            return true;
        }
        return false;
    }

    public void RentVehicle(string model)
    {
        var vehicle = fleet.FirstOrDefault(v => v.Model.Equals(model, StringComparison.OrdinalIgnoreCase) && v.IsAvailable);
        if (vehicle != null)
        {
            vehicle.Rent();
            TotalRevenue += vehicle.RentalPrice;
            Console.WriteLine($"\n{model} has been rented.");
        }
        else
        {
            Console.WriteLine($"\n{model} is currently unavailable.");
        }
    }

    public void ReturnVehicle(string model)
    {
        var vehicle = fleet.FirstOrDefault(v => v.Model.Equals(model, StringComparison.OrdinalIgnoreCase) && !v.IsAvailable);
        if (vehicle != null)
        {
            vehicle.ReturnVehicle();
            Console.WriteLine($"\n{model} has been returned and is now available.");
        }
        else
        {
            Console.WriteLine($"\nCould not find a rented vehicle with model {model}.");
        }
    }

    public void DisplayFleet()
    {
        Console.WriteLine("Fleet Overview:");
        foreach (Vehicle vehicle in fleet)
        {
            vehicle.DisplayDetails();
        }
    }

    public void DisplayAvailableVehicles()
    {
        Console.WriteLine("\nAvailable Vehicles:");
        foreach (var vehicle in fleet.Where(v => v.IsAvailable))
        {
            vehicle.DisplayDetails();
        }
    }

    public void SearchVehicles(string searchTerm)
    {
        var foundVehicles = fleet.Where(v => v.Model.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) 
                                           || v.Manufacturer.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        if (foundVehicles.Any())
        {
            Console.WriteLine($"\nFound Vehicles matching: {searchTerm}");
            foreach (var vehicle in foundVehicles)
            {
                vehicle.DisplayDetails();
            }
        }
        else
        {
            Console.WriteLine($"\nNo vehicles found matching: {searchTerm}");
        }
    }
}
