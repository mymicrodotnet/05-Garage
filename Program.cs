/*
Test: 
1. Object garage correctly created
2. _vehicles = [null, null, null], constructor works correctly
3. ParkVehicle() works properly
4. Registration number is unique
5. Garage full
6. vehicle null (null means: there is no object reference)
*/
Garage garage = new Garage(3);

Car car1 = new Car("ABC123", "Black", 4, Car.FuelType.Gasoline);
Car car2 = new Car("XYZ456", "White", 4, Car.FuelType.Gasoline);
Car car3 = new Car("ABC123", "Red", 4, Car.FuelType.Gasoline);
Car car4 = new Car("ABC111", "White", 4, Car.FuelType.Gasoline);
Car car5 = new Car("ABC222", "Blue", 4, Car.FuelType.Gasoline);

System.Console.WriteLine(garage.ParkVehicle(car1)); // Vehicle successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car2)); // Vehicle successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car3)); // Registration Number duplicated, returns False
System.Console.WriteLine(garage.ParkVehicle(car4)); // Vehicle successfully parked, returns True
System.Console.WriteLine(garage.ParkVehicle(car5)); // Garage full, returns False
System.Console.WriteLine(garage.ParkVehicle(null)); // The vehicle object cannot be null, returns False