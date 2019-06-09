using System;

namespace class_based_inheritance
{
    public class Ram : Vehicle {


        public int FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram cruhes all in its way. RAAAAMMMM!!!!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Ram turns left");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram is stopping, or is it, Ram's never stop");
        }

    }

}