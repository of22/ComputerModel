using System;
using ComputerModel.Hardware.Abstract;
using ComputerModel.Hardware.Interfaces;
using ComputerModel.Software.Concrete;

namespace ComputerModel.Hardware.Concrete
{
    public class AsrockH87 : Motherboard, IRunnable
    {
        public AsrockH87()
        {
            SolidStateDrive = new SamsungSsd();
            CpuFan = new ZalmanOptima();
            Ram = new KingstonRam(); 
            Cpu = new IntelXeon();
            ComputerBoxFan = new ComputerBoxFanZalman();
            Bios = new AsrockBios();
        }


        public void Start()
        {
            Console.WriteLine("Motherboard started");
        }

        public void Stop()
        {
            Console.WriteLine("Motherboard stopped");
        }

        public override void InitBios()
        {

        }
    }
}
