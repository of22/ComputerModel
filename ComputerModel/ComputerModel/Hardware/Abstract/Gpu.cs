namespace ComputerModel.Hardware.Interfaces
{
    public abstract class Gpu
    {
        private string rpm;

        public string Rpm { set; get; }

        private readonly int gHz;

        public int GHz { get; set; }

        private readonly int voltage;

        public int Voltage { set; get; }


    }
}
