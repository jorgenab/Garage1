namespace Garage1
{
    internal class Boat : Vehicle
    {
        public float Length { get; set; }
        public Boat(string regNumber, Color color, int numberOfWheels, float length) : base(regNumber, color, numberOfWheels)
        {
            Length = length;
        }
    }
}