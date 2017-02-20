namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;

    public class SamsungSsd : ISolidStateDrive
    {
        public SamsungSsd()
        {
            Volume = 240;
        }

        public long Volume { get; }

        public void Start()
        {
            Console.WriteLine("SSD started");
        }

        public void Stop()
        {
            Console.WriteLine("SSD stopped");
        }

    }
}
