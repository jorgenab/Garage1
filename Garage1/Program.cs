using System;

namespace Garage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(10);
            UserInterface ui = new UserInterface();
            GarageHandler garageHandler = new GarageHandler();
            IHandler iHandler;
            Airplane airplane;
            Motorcycle motorcycle;
            Car car;
            Bus bus;
            Boat boat;
        }
    }
}
