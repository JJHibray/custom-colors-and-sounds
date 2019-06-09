using System;
using System.Collections.Generic;

namespace class_based_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeep gCherokee = new Jeep()
            {
                MainColor = "hot yellow",
                MaximumOccupancy = 5,
                Cylinders = 8

            };

        Tesla ElectroRide = new Tesla()
            {
                MainColor = "big-head red",
                MaximumOccupancy = 5,
                BatteryKWh = 12.0

            };

        Ram BigTruck = new Ram()
        {
            MainColor = "royal blue",
            MaximumOccupancy = 2,
            FuelCapacity = 25

        };

        Zero fxs = new Zero()
            {
                MainColor = "Midnight",
                MaximumOccupancy = 4,
                BatteryKWh = 23.50

        };

        Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 4,
                FuelCapacity = 102.20
    };

    BigTruck.Drive();
    BigTruck.Turn();
    BigTruck.Stop();
    fxs.Drive();
    fxs.Turn();
    fxs.Stop();
    gCherokee.Beasts();
    gCherokee.Drive();
    gCherokee.Turn();
    gCherokee.Stop();
    mx410.Drive();
    mx410.Turn();
    mx410.Stop();
    ElectroRide.Drive();
    ElectroRide.Turn();
    ElectroRide.Stop();

    }

    }
}
