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

# Screen shots

![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/8a5c82dd-9dfe-4fec-98ea-27877c5c8998)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/aeb8a41e-47fa-40b4-9235-fa1b9af9ddfa)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/78a179f2-43a4-4965-bc8b-40d5df50f833)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/e7b9fdee-c965-4489-a91b-b1e571df5853)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/d3961ad3-1fa1-4b3b-a4a5-b3600731eae0)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/a485013d-8416-4fa1-8907-62927ec943f7)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/ab8e0d4f-8797-46f3-9c46-a4861ec31b0c)
![image](https://github.com/Jenishkumarbhalala/VehicleRentalManagementSystem/assets/142840309/1d522518-8d2d-4340-a956-17f9c9ea51b6)
