using CarSimulatorHiq.DistanceCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulatorHiq
{
    public class Car : IMoveable
    {
        public int X { get; set; } //width
        public int Y { get; set; } //height
        public string _direction { get; set; }
        public Car()
        {
            
        }

        public Car(string height, string width, string direction)
        {
            X = Int32.Parse(height);
            Y = Int32.Parse(width);
            _direction = direction;
        }
        //implementation for getting the absolute position of the car if needed. can be used in future implementations for getting the position of a single object easily.
        public virtual List<int> getPosition()
        {
            List<int> newList = new List<int>();
            newList.Add(X + Y);
            return newList;
        }
    }
}
