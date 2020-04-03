using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;

        private int capacity;
              
        public Garage(int aCapacity)
        {
            capacity = aCapacity;
            vehicles = new Vehicle[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}