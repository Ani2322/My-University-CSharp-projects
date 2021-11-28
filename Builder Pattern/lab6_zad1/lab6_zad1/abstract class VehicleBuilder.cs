using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad1
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract void BuildSeat();
    }
}
