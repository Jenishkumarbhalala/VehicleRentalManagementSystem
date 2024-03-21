# VehicleRentalManagementSystem

## Overview
The Vehicle Rental Management System is a console application designed to manage a fleet of vehicles for rental purposes. The system allows for adding vehicles to the fleet, renting them out, returning them, and performing various queries to manage and review the fleet and its revenue.

## Features
- Add vehicles to the rental fleet, including cars, trucks, and motorcycles, each with specific attributes.
- Display the entire fleet, or filter to show only available vehicles.
- Rent out vehicles based on the model, adjusting fleet availability and tracking revenue.
- Return rented vehicles, making them available again for rental.
- Remove vehicles from the fleet.
- Search for vehicles by model or manufacturer.
- View total revenue generated from vehicle rentals.

## Classes and Their Functions

**- Vehicle (Abstract Class):** Serves as a base class for different types of vehicles, holding common properties like model, manufacturer, year, and rental price.

**- Car:** Inherits from Vehicle, adding properties specific to cars such as seats, engine type, transmission, and whether it's convertible.

**- Truck:** Inherits from Vehicle, with additional properties like capacity, truck type, and whether it has four-wheel drive.

**- Motorcycle:** Inherits from Vehicle, including properties like engine capacity, fuel type, and whether it has fairing.

**- RentalAgency:** Manages the fleet of vehicles, handling adding, removing, renting, returning vehicles, and displaying fleet information.

**- Program:** Contains the main method, providing a user interface for interacting with the RentalAgency class and managing the fleet.

# Screen shots:

 

 

 

 

 

 

 

 

