namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;

    public class KingstonRam : IRam
    {
        public KingstonRam()
        {
            Timings = 10;
            MHz = 1600;
            Volume = 16;
        }
        public int Timings { get; set; }
        public int MHz { get; set; }
        public int Volume { get; set; }

        public void Start()
        {
            Console.WriteLine("Ram started");
        }

        public void Stop()
        {
            Console.WriteLine("Ram stopped");
        }
    }
}
