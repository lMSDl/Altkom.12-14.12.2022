using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    internal class RealObject : AbstractObject
    {
            public override void Method3()
            {
                Console.WriteLine("3");
            }
    }
}
