namespace Observers
{
    public interface ISubject
    {
        ConsoleWriter Key { get;}
        void RegisterObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
    }
}