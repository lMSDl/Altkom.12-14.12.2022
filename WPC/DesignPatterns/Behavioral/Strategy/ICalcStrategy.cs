using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Strategy
{
    internal interface ICalcStrategy
    {
        float Calc(float a, float b);
    }
}
