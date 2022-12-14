using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Composite
{
    public abstract class Leaf : IComponent, IProduct
    {
        public string Name => GetType().Name;
        public float Price { get; set; }

        protected Leaf(float price)
        {
            Price = price;
        }

        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name} to {Price}");
            return Price;
        }
    }
}
