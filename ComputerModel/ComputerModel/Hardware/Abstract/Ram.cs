namespace ComputerModel.Hardware.Interfaces
{
    public abstract class Ram
    {
        public readonly int timings ;

        public int Timings { set; get; }

        public readonly int mHz ;

        public int MHz { set; get; }

        public readonly int volume ;

        public int Volume { set; get; }

    }
}
