using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Facade.III
{
    internal interface IXmlConverter
    {
        string ToXml<T>(T item);
    }
}
