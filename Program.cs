/*
Test: 
1. Object garage correctly created
2. _vehicles = [null, null, null], constructor works correctly
3. ParkVehicle() works properly
4. Registration number is unique
5. Garage full
6. vehicle null (null means: there is no object reference)
7. Remove vehicle case-insensitive
8. Validate Vehicle properties
9. List of vehicles in the garage

*/
Garage garage = new Garage(3);

Car car1 = new Car("ABC123", "Black", 4, Car.FuelType.Gasoline);
Car car2 = new Car("XYZ456", "White", 4, Car.FuelType.Gasoline);
Car car3 = new Car("ABC123", "Red", 4, Car.FuelType.Gasoline);
Car car4 = new Car("ABC111", "White", 4, Car.FuelType.Gasoline);
Car car5 = new Car("ABC222", "Blue", 4, Car.FuelType.Gasoline);

System.Console.WriteLine(garage.ParkVehicle(car1)); // Vehicle ABC123 successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car2)); // Vehicle XYZ456 successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car3)); // Registration Number ABC123 duplicated, returns False
System.Console.WriteLine(garage.ParkVehicle(car4)); // Vehicle ABC111 successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car5)); // Garage full, returns False
System.Console.WriteLine(garage.ParkVehicle(null)); // The vehicle object cannot be null, returns False
System.Console.WriteLine(garage.RemoveVehicle("ABC222")); // Vehicle's registration number: ABC222 not found, returns False
System.Console.WriteLine(garage.RemoveVehicle("Abc111")); // Vehicle's registration number: Abc111 successfully removed, returns True
System.Console.WriteLine(garage.ParkVehicle(car5)); // Vehicle ABC222 successfully parked, returns True. Reuses the freed slot.

try
{
    Car car6 = new Car(null, "Blue", 4, Car.FuelType.Gasoline);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation test passed: {ex.Message}"); // Validation test passed: Registration number cannot be null, empty, or whitespace. (Parameter 'registrationNumber')
}

try
{
    Car car7 = new Car("", "Blue", 4, Car.FuelType.Gasoline);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation test passed: {ex.Message}"); // Validation test passed: Registration number cannot be null, empty, or whitespace. (Parameter 'registrationNumber')
}

try
{
    Car car7 = new Car("ABC777", "Blue", -1, Car.FuelType.Gasoline);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Validation test passed: {ex.Message}"); // Validation test passed: Number of wheels cannot be negative. (Parameter 'numberOfWheels')
}

try
{
    Car car8 = new Car("", "", 4, Car.FuelType.Gasoline);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation test passed: {ex.Message}"); // Validation test passed: Registration number cannot be null, empty, or whitespace. (Parameter 'registrationNumber')
}

try
{
    Car car9 = new Car("ABC999", null, 4, Car.FuelType.Gasoline);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation test passed: {ex.Message}"); // Validation test passed: Registration number cannot be null, empty, or whitespace. (Parameter 'registrationNumber')
}

Vehicle[] allVehiclesInGarage = garage.ListVehicles();
foreach (Vehicle vehicle in allVehiclesInGarage)
{
    System.Console.WriteLine($"{vehicle.RegistrationNumber}"); // ABC123 XYZ456 ABC222
}