using System;
using ComputerModel.Hardware.Concrete;
using ComputerModel.Software.Concrete;

namespace ComputerModel
{
    using Hardware.Interfaces;

    class Program
    {
        static void Main()
        {

            ComputerBoxZalmanZ11 zalmanZ11 = StartComputer();

            zalmanZ11.PowerOnAndInitBios(zalmanZ11.Motherboard);

            Console.ReadLine();
        }

        public static ComputerBoxZalmanZ11 StartComputer() => new ComputerBoxZalmanZ11(
            new AsrockH87(
                new IntelXeon(), 
                new KingstonRam(),
                new ZalmanOptima(),
                new SamsungSsd(),
                new NVidia(
                    new AsusGpuFan()
                    ), 
                new AsrockBios() 
            ),
            new ComputerBoxFanZalman(),
            new Chieftec()  
        );
    }
}
