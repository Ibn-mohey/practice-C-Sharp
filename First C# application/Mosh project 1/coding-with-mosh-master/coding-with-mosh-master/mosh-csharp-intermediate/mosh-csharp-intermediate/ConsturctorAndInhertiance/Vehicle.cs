using System;

namespace mosh_csharp_intermediate.ConstructorAndInhertiance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initalized");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
}