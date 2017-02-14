using System;
using ComputerModel.Interfaces;

namespace ComputerModel.Hardware.Abstract
{
    public abstract class Ram : IRunnable
    {
        protected Ram (int timings, int mHz, int volume )
        {
            Timings = timings;
            MHz = mHz;
            Volume = volume;
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
