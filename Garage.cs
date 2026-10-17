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
        this._vehicles = new Vehicle[capacity];
        // Creates an array with 'capacity' positions.
        // Each position initially contains null because
        // Vehicle is a reference type.
        // 'this' refers to the current object and is optional here.
    }
}