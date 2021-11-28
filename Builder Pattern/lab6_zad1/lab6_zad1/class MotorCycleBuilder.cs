using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad1
{
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }
        public override void BuildFrame()
        {
            vehicle.Add("Motorcycle Frame");
        }
        public override void BuildEngine()
        {
            vehicle.Add("Engine 500 cc");
        }
        public override void BuildWheels()
        {
            vehicle.Add("Wheels 2");
        }
        public override void BuildDoors()
        {
            vehicle.Add("Doors 0");
        }
        public override void BuildSeat()
        {
            vehicle.Add("Seаts 1");
        }

    }
}
