/*
Airplane inherits the common properties from Vehicle.
*/
public class Airplane : Vehicle
{
    // Properties
    public int NumberOfEngines {get; set;}
    
    public override decimal ParkingSpaceRequirement => 3m;
    
    // Constructor
    public Airplane(
        string registrationNumber, 
        string color, 
        int numberOfWheels, 
        int numberOfEngines): base(registrationNumber, color, numberOfWheels){
        NumberOfEngines = numberOfEngines;
    }

}