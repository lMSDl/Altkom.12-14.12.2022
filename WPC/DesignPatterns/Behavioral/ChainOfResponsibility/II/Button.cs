using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Button : Component
    {
        public Func<bool> OnClick { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && OnClick())
                base.Click(true);
            else
                base.Click(handled);
        }
    }
}
