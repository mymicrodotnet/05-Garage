public class Vehicle
{
    // Public auto-properties
    public string RegistrationNumber { get; set; }
    public string Color { get; set; }
    public int NumberOfWheels { get; set; }

    // Constructor
    public Vehicle(string registrationNumber, string color, int numberOfWheels)
    {
        RegistrationNumber = registrationNumber;
        Color = color;
        NumberOfWheels = numberOfWheels;
    }

}