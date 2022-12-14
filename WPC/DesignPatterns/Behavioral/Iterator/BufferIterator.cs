using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private IEnumerator<T> _baseEnumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _baseEnumerator = enumerator;
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _baseEnumerator.Dispose();
            _baseEnumerator = null;
            Current = default;
        }

        public bool MoveNext()
        {
            if (_baseEnumerator.MoveNext())
            {
                Current = new Tuple<T, T>(Current.Item2, _baseEnumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _baseEnumerator.Reset();
            if (_baseEnumerator.MoveNext())
            {
                Current = new Tuple<T, T>(default, _baseEnumerator.Current);
            }
            else
                Current = default;
        }
    }
}
