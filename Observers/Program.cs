using System;

namespace Observers
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new keyReader();

            IObserver obs1 = new ConsoleWriter();
            IObserver obs2 = new FileWriter();

            subject.RegisterObserver(obs1);
            subject.RegisterObserver(obs2);

            Console.WriteLine();
        }
    }
}
