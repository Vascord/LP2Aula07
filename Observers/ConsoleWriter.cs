namespace Observers
{
    public class ConsoleWriter : IObserver
    {
        public void Update(ISubject subj)
        {
            ConsoleWriter.WriterLine(subj.Key);
        }
    }
}