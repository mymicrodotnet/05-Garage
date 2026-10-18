/*
The class Garage stores a collection of vehicles
The collection must be an array
The array must be private. Access modifier: private.
The garage capacity must be specified through the constructor.
*/
public class Garage
{
    // Fields
    private Vehicle[] _vehicles; // private: _vehicles can only be accessed from inside the class.

    // Constructors: same name as the class, none return type.
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
                System.Console.WriteLine("Registration Number duplicated.");
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
                System.Console.WriteLine("Vehicle successfully parked.");
                return true; // parked
            }
        }
        System.Console.WriteLine("Garage full.");
        return false; // full
    }
}