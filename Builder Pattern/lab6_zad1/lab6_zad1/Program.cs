using System;

namespace lab6_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder[] vehicleBuilders = new VehicleBuilder[3];
            Director producer = new Director();
            vehicleBuilders[0] = new CarBuilder();
            producer.Construct(vehicleBuilders[0]);
            vehicleBuilders[0].Vehicle.Show();
            Console.WriteLine();
            vehicleBuilders[1] = new MotorCycleBuilder();
            producer.Construct(vehicleBuilders[1]);
            vehicleBuilders[1].Vehicle.Show();
            Console.WriteLine();
            vehicleBuilders[2] = new BusBuilder();
            producer.Construct(vehicleBuilders[2]);
            vehicleBuilders[2].Vehicle.Show();


        }
    }
}
