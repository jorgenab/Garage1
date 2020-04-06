using System;
using System.Collections;
using System.Collections.Generic;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;

        private int capacity;

        public int VehiclesInGarage { get; set; }

        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new T[this.capacity];
            vechiclesInGarage = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        // Adds a Vehicle to the garage.
        // If the garage is full do nothing, otherwise
        // add the vehicle to the garage.
 
        public void AddTo(T vehicle)
        {
            if (!GarageFull())
            {
                for (int vehicleIndex = 0; vehicleIndex < capacity; vehicleIndex++)
                {
                    if (vehicles[vehicleIndex] == null)
                    {
                        vehicles[vehicleIndex] = vehicle;
                        VehiclesInGarage++;
                        return;
                    }
                }
            }
        }

        private bool GarageFull()
        {
            return VehiclesInGarage == capacity;
        }

        // Removes a Vehicle from the garage.
        // If the garage is empty or the vehicle in not found in
        // the garage do nothing, otherwise remove the vehicle from the
        // garage.
        public void RemoveFrom(T vehicle)
        {
            if (!GarageEmpty())
            {
                for (int vehicleIndex = 0; vehicleIndex < capacity; vehicleIndex++)
                {
                    if (vehicles[vehicleIndex] == vehicle)
                    {
                        vehicles[vehicleIndex] = null;
                        VehiclesInGarage--;
                        return;
                    }
                }
             }
        }

        private bool GarageEmpty()
        {
            return VehiclesInGarage == 0;
        }
    }
}