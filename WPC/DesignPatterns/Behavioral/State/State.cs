using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.State
{
    internal abstract class State
    {
        protected CoffeeMachine CoffeeMachine { get; }
        protected State(CoffeeMachine coffeeMachine)
        {
            CoffeeMachine = coffeeMachine;
        }
        public abstract void Small();
        public abstract void Large();
    }
}
