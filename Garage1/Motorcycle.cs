namespace Garage1
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(string regNumber, Color color, int numberOfWheels, int cylinderVolume) : base(regNumber, color, numberOfWheels)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}