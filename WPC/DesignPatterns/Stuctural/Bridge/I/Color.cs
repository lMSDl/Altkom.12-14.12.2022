using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Bridge.I
{
    internal abstract class Color
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
