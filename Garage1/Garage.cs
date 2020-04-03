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
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddTo(Vehicle vehicle)
        {
            
        }

        public void RemoveFrom(Vehicle vehicle)
        {

        }
    }
}