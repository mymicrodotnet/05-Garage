/*
Boat inherits the common properties from Vehicle.
*/
public class Boat : Vehicle
{
    // Properties
    public double Length { get; set; }
    public override decimal ParkingSpaceRequirement => 2m;

    // Constructor
    public Boat(
        string registrationNumber,
        string color,
        int numberOfWheels,
        double length
    ) : base(registrationNumber, color, numberOfWheels)
    {
        Length = length;
    }
}
