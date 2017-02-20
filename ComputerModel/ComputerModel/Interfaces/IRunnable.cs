namespace ComputerModel.Interfaces
{
    public interface IRunnable
    {
        void Start();

        void Stop();
    }

    public interface IRunnable<in T>
    {
        void Start(T element);

        void Stop(T item);
    }
}
