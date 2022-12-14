using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    internal abstract class Subscriber : IObserver<int>
    {
        public IDisposable? Subscription { get; set; }
        public void OnCompleted()
        {
            Subscription?.Dispose();
            Subscription = null;
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name} otrzymał powiadomienie o błędzie: {error}");
        }

        public abstract void OnNext(int value);
    }
}
