using System;

namespace class_based_inheritance {
public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        Console.WriteLine("Battery charging...");
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero races past you. zzzrrrroooommmm!");
    }

    public override void Turn()
        {
            Console.WriteLine("The Zero turns left");
        }

        public override void Stop()
        {
            Console.WriteLine("The Zero stops due to a gentle wind");
        }

}

}