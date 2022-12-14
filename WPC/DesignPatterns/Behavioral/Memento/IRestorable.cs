using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T>
    {
        void Restore(T state);
    }
}
