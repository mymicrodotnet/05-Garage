public class Garage
{
    // Fields
    private Vehicle[] _vehicles;
    // Constructor
    public Garage(int capacity)
    {
        this._vehicles = new Vehicle[capacity];
        // Creates an array with 'capacity' positions.
        // Each position initially contains null because
        // Vehicle is a reference type.
        // 'this' refers to the current object and is optional here.
    }
}