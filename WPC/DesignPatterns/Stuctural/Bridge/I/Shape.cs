using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Bridge.I
{
    internal abstract class Shape
    {

        public Color? Color { get; set; }

        public override string ToString()
        {
            return (Color?.ToString() ?? "") + GetType().Name;
        }
    }
}
