using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    internal class Memento<T> where T : ICloneable
    {
        private T _state;
        public DateTime DateTime { get; }

        public Memento(T state)
        {
            _state = (T)state.Clone();
            DateTime = DateTime.Now;
        }

        public T GetState()
        {
            return (T)_state.Clone();
        }
    }
}
