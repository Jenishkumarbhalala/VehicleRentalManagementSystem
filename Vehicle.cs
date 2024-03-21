public abstract class Vehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public decimal RentalPrice { get; set; }
    public bool IsAvailable { get; set; } = true;

    protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"\nModel: {Model}, \nManufacturer: {Manufacturer}, \nYear: {Year}, \nRental Price: ${RentalPrice}, \nAvailable: {IsAvailable}");
    }

    public void Rent()
    {
        IsAvailable = false;
    }

    public void ReturnVehicle()
    {
        IsAvailable = true;
    }
}
