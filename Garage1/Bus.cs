namespace Garage1
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Bus(string regNumber, Color color, int numberOfWheels, int numberOfSeats) : base(regNumber, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}