namespace Garage1
{
    internal class Car : Vehicle
    {
        public FuelType FuelType { get; set; }

        public Car(string regNumber, Color color, int numberOfWheels, FuelType fuelType) : base(regNumber, color, numberOfWheels)
        {
            FuelType = fuelType;
        }
    }

  
}