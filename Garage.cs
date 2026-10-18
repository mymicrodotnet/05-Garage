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
        // Input validation: rejects a null vehicle
        if (vehicle == null)
        {
            return false; // vehicle is null
        }

        // find the first null in the array to park a vehicle
        for (int i = 0; i < _vehicles.Length; i++)
        {
            // stores the vehicle in the first empty position.
            if (_vehicles[i] == null)
            {
                _vehicles[i] = vehicle;
                System.Console.WriteLine("Vehicle successfully parked");
                return true; // parked
            }
        }
        System.Console.WriteLine("Garage full");
        return false; // full
    }
}