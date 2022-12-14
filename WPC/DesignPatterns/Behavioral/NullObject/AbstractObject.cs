using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    internal abstract class AbstractObject
    {
        public void Method1()
        {
            Console.WriteLine("1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("2");
        }

        public abstract void Method3();
    }
}
