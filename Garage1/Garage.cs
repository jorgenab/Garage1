using System.Collections;
using System.Collections.Generic;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;

        private int capacity;
              
        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new Vehicle[this.capacity];
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

        // Adds a Vehicle to the garage
        public void AddTo(Vehicle vehicle)
        {
            
        }

        // Removes a Vehicle from the garage
        public void RemoveFrom(Vehicle vehicle)
        {

        }
    }
}