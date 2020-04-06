namespace Garage1
{
    internal class Vehicle
    {
        public string RegNumber { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }

        public Vehicle(string regNumber, Color color, int numberOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
    }
}