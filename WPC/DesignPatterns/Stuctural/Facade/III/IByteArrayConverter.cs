using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Facade.III
{
    internal interface IByteArrayConverter
    {
        byte[] ToByteArray<T>(T item);
    }
}
