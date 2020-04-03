using System.Drawing;

namespace Garage1
{
    internal class Vehicle
    {
        public string RegNumber { get; set; }
        public Color Color { get; set; }
        public int NrOfWheels { get; set; }

        public Vehicle(string regNumber, Color color, int nrOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NrOfWheels = nrOfWheels;
        }
    }
}