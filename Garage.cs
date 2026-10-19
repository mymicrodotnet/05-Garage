/*
The class Garage stores a collection of vehicles
The collection must be an array
The array must be private. Access modifier: private.
The garage capacity must be specified through the constructor.
*/
public class Garage
{
    // Field
    private Vehicle[] _vehicles; // private: _vehicles can only be accessed from inside the class.

    // Constructor: same name as the class, none return type.
    public Garage(int capacity)
    {
        // Validate capacity to ensure the garage has a positive capacity. Throw an exception if the argument is invalid.
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(capacity),
                "Garage capacity must be greater than zero."
            );
        }
        this._vehicles = new Vehicle[capacity];
        // Creates an array with 'capacity' positions.
        // Each position initially contains null because
        // Vehicle is a reference type.
        // 'this' refers to the current object and is optional here.

    }

    // Methods
    # region ParkVehicle
    // Method: The public access modifier allows Program.cs to call this method.
    public bool ParkVehicle(Vehicle vehicle)
    {
        // Parameter validation: checks the incoming method parameter vehicle exists. Rejects a null vehicle passed by mistake to this method. Example: garage.ParkVehicle(null). 
        if (vehicle == null)
        {
            System.Console.WriteLine("The vehicle object cannot be null.");
            return false; // vehicle is null
        }

        // Duplicate validation: registration number must be unique.
        for (int j = 0; j < _vehicles.Length; j++)
        {
            if (_vehicles[j] != null &&
            _vehicles[j].RegistrationNumber.ToUpper() == vehicle.RegistrationNumber.ToUpper()) // _vehicles[j] != null to ensure the slot contains a vehicle before accessing its properties. When _vehicles[j] is null, C# never evaluates _vehicles[j].RegistrationNumber, avoiding a NullReferenceException.
            {
                System.Console.WriteLine($"Registration Number {vehicle.RegistrationNumber} duplicated.");
                return false;
            }
        }

        // Find the first null in the array to park a vehicle. Finds a parking spot.
        for (int i = 0; i < _vehicles.Length; i++)
        {
            // Stores the vehicle in the first empty position.
            if (_vehicles[i] == null)
            {
                _vehicles[i] = vehicle;
                System.Console.WriteLine($"Vehicle {vehicle.RegistrationNumber} successfully parked.");
                return true; // parked
            }
        }
        System.Console.WriteLine("Garage full.");
        return false; // full
    }
    #endregion

    #region RemoveVehicle
    // Method: Remove vehicle by registration number case-insensitive.
    public bool RemoveVehicle(string registrationNumber)
    {
        // Parameter validation.
        if (string.IsNullOrWhiteSpace(registrationNumber))
        {
            System.Console.WriteLine($"The registration number {registrationNumber} cannot be null or empty");
            return false;
        }

        // Search for the vehicle in the array _vehicles.
        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null && _vehicles[i].RegistrationNumber.ToUpper() == registrationNumber.ToUpper())
            {
                // Remove the vehicle by making its array position empty.
                _vehicles[i] = null;
                System.Console.WriteLine($"Vehicle's registration number: {registrationNumber} successfully removed.");
                return true;
            }
        }
        System.Console.WriteLine($"Vehicle's registration number: {registrationNumber} not found.");
        return false;
    }
    #endregion

    #region ListVehicles
    // Method: If countVehicles=0, the array allVehiclesInGarage does not store elements because there are no vehicles to copy
    public Vehicle[] ListVehicles()
    {
        int countVehicles = 0;

        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null)
            {
                countVehicles++;
            }
        }
        Vehicle[] allVehiclesInGarage = new Vehicle[countVehicles]; // If countVehicles = 0, Vehicle[] allVehiclesInGarage = new Vehicle[0], is valid in C# -> An array exists with zero elements. This method would return an empty array.

        int counter = 0;

        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null)
            {
                allVehiclesInGarage[counter] = _vehicles[i]; // If countVehicles=0, the array allVehiclesInGarage does not store elements because there are no vehicles to copy
                // System.Console.WriteLine($"{allVehiclesInGarage[counter].RegistrationNumber}");
                counter++;
            }
        }
        return allVehiclesInGarage;
    }
    #endregion

    #region FindVehicleByRegistrationNumber
    // Method: returns the whole vehicle if registration number found. Returns null if not. Adding the nullability annotation (?), explicitly tells the compiler that returning null is intentional and allowed.
    public Vehicle? FindVehicleByRegistrationNumber(string registrationNumber)
    {
        if (string.IsNullOrWhiteSpace(registrationNumber))
        {
            System.Console.WriteLine($"The registration number {registrationNumber} cannot be null or empty");
            return null;
        }

        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null && registrationNumber.ToUpper() == _vehicles[i].RegistrationNumber.ToUpper())
            {
                System.Console.WriteLine($"The vehicle {_vehicles[i].RegistrationNumber} found.");
                return _vehicles[i];
            }
        }
        System.Console.WriteLine($"The vehicle {registrationNumber} not found.");
        return null;
    }
    #endregion

    #region FindVehicleByColor
    // Method: Returns an empty array if the color is invalid or no vehicles match, avoiding null checks in the caller. In other words, returns an empty array for invalid color input or when no vehicles match, so callers can iterate without checking for null. If countVehicles=0, the array allVehiclesByColor does not store elements because there are no vehicles to copy
    public Vehicle[] FindVehiclesByColor(string color)
    {
        if (string.IsNullOrWhiteSpace(color))
        {
            System.Console.WriteLine("The color of the vehicle cannot be null, empty or have spaces.");
            return []; // empty array
        }

        int countVehicles = 0;

        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null && _vehicles[i].Color.ToUpper() == color.ToUpper())
            {
                countVehicles++;
            }
        }

        Vehicle[] allVehiclesByColor = new Vehicle[countVehicles];
        int counter = 0;
        for (int i = 0; i < _vehicles.Length; i++)
        {
            if (_vehicles[i] != null && _vehicles[i].Color.ToUpper() == color.ToUpper())
            {
                allVehiclesByColor[counter] = _vehicles[i];
                counter++;
            }
        }
        return allVehiclesByColor;
    }
    #endregion

}

