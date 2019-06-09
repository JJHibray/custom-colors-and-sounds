using System;

namespace class_based_inheritance
{
    public class Jeep : Vehicle {


        public int Cylinders { get; set; }
        public void Beasts()
        {
            Console.WriteLine("The Jeep beasts over the onoming obstacles");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Jeep beasts over thing in it's way. BEEEASSSSSTTTSSS!!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Jeep turns left");
        }

        public override void Stop()
        {
            Console.WriteLine("The Jeep hit a deer and stops permanently");
        }

    }

}