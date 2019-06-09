using System;

namespace class_based_inheritance
{
    public class Vehicle
{

    // protected string _name;

    // public Vehicle(string name) {
    //     _name = name;
    // }
            public string MainColor { get; set; }
            public int MaximumOccupancy { get; set; }

            public virtual void Drive() {
            Console.WriteLine("Vrooom!");
            }

            public virtual void Wipers()
            {
                Console.WriteLine("The wipers sweep rain off the car");
            }

            public virtual void Turn()
            {
                Console.WriteLine("The vehicle turns left.");
            }
            public virtual void Stop()
            {
                Console.WriteLine("The vehicle comes to a stop.");
            }
}
}
