using System;

namespace ComputerModel.Hardware.Concrete
{
    using Interfaces;

    public class ComputerBoxZalmanZ11 : IComputerBox
    {
        public IMotherboard Motherboard { get; }
        public IFan ComputerBoxFan { get; }
        public IPowerSupply PowerSupply { get; }

        public ComputerBoxZalmanZ11(IMotherboard motherboard, IFan computerBoxFan, IPowerSupply powerSupply)
        {
            Motherboard = motherboard;
            ComputerBoxFan = computerBoxFan;
            PowerSupply = powerSupply;
        }

        public  void Start()
        {
            Console.WriteLine("Started Computer");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped Computer");
        }

        public void PowerOnAndInitBios(IMotherboard motherboard)
        {
            PowerSupply.Start();
            ComputerBoxFan.Start();
            motherboard.Start();
            motherboard.Bios.Start(motherboard);
            Console.WriteLine("***** Turned on Computer ******");
        }

}
}
