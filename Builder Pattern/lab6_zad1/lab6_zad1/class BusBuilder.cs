using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad1
{
    class BusBuilder : VehicleBuilder
    {
        public BusBuilder()
        {
            vehicle = new Vehicle("Bus");
        }
        public override void BuildFrame()
        {
            vehicle.Add("Bus Frame");
        }
        public override void BuildEngine()
        {
            vehicle.Add("Engine 3000 cc");
        }
        public override void BuildWheels()
        {
            vehicle.Add("Wheels 6");
        }
        public override void BuildDoors()
        {
            vehicle.Add("Doors 3");
        }
        public override void BuildSeat()
        {
            vehicle.Add("Seаts 20");
        }

    }
}
