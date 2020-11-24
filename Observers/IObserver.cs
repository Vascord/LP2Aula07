namespace Observers
{
    public interface IObserver
    {
        void Update(ISubject subj);
    }
}