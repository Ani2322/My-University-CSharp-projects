using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_zad1
{
    class Director
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildSeat();
        }
    }
}
