namespace Observers
{
    public class KeyReader : ISubject
    {
        private ICollection<IObserver> observers;

        public ConsoleKey Key 
        {
            get => value; 
            
            private set =>
            NotifyObservers();
            
        }

        public void RegisterObserver(IObserver obs)
        {
            observers.Add(obs);
        }
        public void RemoveObserver(IObserver obs)
        {
            observers.Remove(obs);
        }

        public KeyReader()
        {
            observers = new HashSet<IObserver>();
        }

        public void ReadKeys()
        {
            ConsoleKey key;
            do
            {
                Key = Console.ReadKey(true).Key;
                NotifyObservers();
            }
            while (key != ConsoleKey.Escape);
        }

        private void NotifyObservers()
        {
            foreach(IObserver obs in observers)
            {
                obs.Update(this);
            }
        }
    }
}