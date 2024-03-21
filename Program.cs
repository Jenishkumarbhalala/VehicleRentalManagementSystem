using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency rentalAgency = new RentalAgency();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nVehicle Rental Management System");
            Console.WriteLine("\n1. Add Vehicle");
            Console.WriteLine("2. Display Fleet");
            Console.WriteLine("3. Rent Vehicle");
            Console.WriteLine("4. Return Vehicle");
            Console.WriteLine("5. Display Available Vehicles");
            Console.WriteLine("6. Search Vehicles");
            Console.WriteLine("7. Remove Vehicle");
            Console.WriteLine("8. Total Revenue");
            Console.WriteLine("9. Exit");
            Console.Write("\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddVehicle(rentalAgency);
                    break;
                case "2":
                    rentalAgency.DisplayFleet();
                    break;
                case "3":
                    RentVehicle(rentalAgency);
                    break;
                case "4":
                    ReturnVehicle(rentalAgency);
                    break;
                case "5":
                    rentalAgency.DisplayAvailableVehicles();
                    break;
                case "6":
                    SearchVehicles(rentalAgency);
                    break;
                case "7":
                    RemoveVehicle(rentalAgency);
                    break;
                case "8":
                    DisplayTotalRevenue(rentalAgency);
                    break;
                case "9":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter vehicle type (Car/Truck/Motorcycle): ");
        string type = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Manufacturer: ");
        string manufacturer = Console.ReadLine();
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Rental Price: ");
        decimal rentalPrice = decimal.Parse(Console.ReadLine());

        switch (type.ToLower())
        {
            case "car":
                Console.Write("Seats: ");
                int seats = int.Parse(Console.ReadLine());
                Console.Write("Engine Type: ");
                string engineType = Console.ReadLine();
                Console.Write("Transmission: ");
                string transmission = Console.ReadLine();
                Console.Write("Convertible (true/false): ");
                bool convertible = bool.Parse(Console.ReadLine());
                rentalAgency.AddVehicle(new Car(model, manufacturer, year, rentalPrice, seats, engineType, transmission, convertible));
                break;
            case "truck":
                Console.Write("Capacity: ");
                double capacity = double.Parse(Console.ReadLine());
                Console.Write("Truck Type: ");
                string truckType = Console.ReadLine();
                Console.Write("Four Wheel Drive (true/false): ");
                bool fourWheelDrive = bool.Parse(Console.ReadLine());
                rentalAgency.AddVehicle(new Truck(model, manufacturer, year, rentalPrice, capacity, truckType, fourWheelDrive));
                break;
            case "motorcycle":
                Console.Write("Engine Capacity: ");
                int engineCapacity = int.Parse(Console.ReadLine());
                Console.Write("Fuel Type: ");
                string fuelType = Console.ReadLine();
                Console.Write("Has Fairing (true/false): ");
                bool hasFairing = bool.Parse(Console.ReadLine());
                rentalAgency.AddVehicle(new Motorcycle(model, manufacturer, year, rentalPrice, engineCapacity, fuelType, hasFairing));
                break;
            default:
                Console.WriteLine("Unknown vehicle type.");
                break;
        }
        Console.WriteLine($"\n{type} added successfully.");
    }

    static void RentVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter the model of the vehicle to rent: ");
        string model = Console.ReadLine();
        rentalAgency.RentVehicle(model);
    }

    static void ReturnVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter the model of the vehicle to return: ");
        string model = Console.ReadLine();
        rentalAgency.ReturnVehicle(model);
    }

    static void SearchVehicles(RentalAgency rentalAgency)
    {
        Console.Write("Enter search term (Model/Manufacturer): ");
        string searchTerm = Console.ReadLine();
        rentalAgency.SearchVehicles(searchTerm);
    }

    static void RemoveVehicle(RentalAgency rentalAgency)
    {
        Console.Write("Enter the model of the vehicle to remove: ");
        string model = Console.ReadLine();
        bool removed = rentalAgency.RemoveVehicle(model);
        if (removed)
        {
            Console.WriteLine($"\n{model} has been successfully removed.");
        }
        else
        {
            Console.WriteLine($"\nCould not find {model} in the fleet.");
        }
    }
    static void DisplayTotalRevenue(RentalAgency rentalAgency)
    {
        Console.WriteLine($"\nTotal Revenue is: ${rentalAgency.TotalRevenue}");
    }
}
