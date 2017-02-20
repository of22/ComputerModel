namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;

    public class Chieftec : IPowerSupply
    {
        public Chieftec() 
        {
            Power = 500;
        }

        public void Start()
        {
            Console.WriteLine("Turned on power supply");
            Console.WriteLine($"Power supply power =  {Power} watt");
        }

        public void Stop()
        {
            Console.WriteLine("Turned off power supply");
        }

        public int Power { get; }
    }
}
