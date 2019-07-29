using System;
using System.Collections.Generic;
using System.Text;

namespace _01_BasicInheritance
{
    class Car
    {
        public readonly int MaxSpeed;
        private int currSpeed;

        public Car(int max)
        {
            MaxSpeed = max;
        }
        public Car()
        {
            MaxSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > MaxSpeed)
                    currSpeed = MaxSpeed;
            }
        }

    }
}
