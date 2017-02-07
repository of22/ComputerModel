using System;
using ComputerModel.Hardware.Interfaces;

namespace ComputerModel.Hardware.Concrete
{
    public class KingstonRam : Ram, IRunnable
    {
        public KingstonRam()
        {
            Volume = 15;
            MHz = 1600;
            Timings = 10;
        }

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
