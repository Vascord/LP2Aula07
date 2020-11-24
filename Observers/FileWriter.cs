namespace Observers
{
    public class FileWriter : IObserver
    {
        public void Update(ISubject subj)
        {
            FileWriter.AppendAllText(
                "output.txt", kr.Key.ToString()
            );
        }
    }
}