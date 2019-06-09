using System;

namespace class_based_inheritance
{
    public class Tesla : Vehicle {


        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla flies by eith its electric power. WWWEEEEEEEEEEEEE!!!!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Tesla turns around");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla stops after battery ran out of power");
        }

    }

}