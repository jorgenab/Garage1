namespace Garage1
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Airplane(string regNumber, Color color, int numberOfWheels, int numberOfEngines) : base(regNumber, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}