namespace ComputerModel.Hardware.Concrete
{
    using System;
    using Interfaces;

    public class NVidia : IGpu
    {
        public NVidia(IFan fan)
        {
            GHz = 1;
            Voltage = 5;
            Rpm = 100;
            Fan = fan;
        }
        
        public IFan Fan { get; }
        public int GHz { get; }
        public int Voltage { get; }
        public int Rpm { get; set; }

        public void InitializeProcessingUnit()
        {
            Console.WriteLine("GPU is ready for use");
        }

        public void TurnOffProcessingUnit()
        {
            Console.WriteLine("Powered off GPU");
        }

        public void Start()
        {
            Console.WriteLine("Started IGpu");
            Fan.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Stopped IGpu");
        }

    }
}
