using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Composite
{
    internal class Box : Composite, IProduct
    {
        public float Price { get; }
        public Box()
        {
        }
        public Box(float price)
        {
            Price = price;
        }

        public override float GetValue()
        {
            var value = base.GetValue();
            if (Price > 0)
            {
                value += Price;
                Console.WriteLine($"Wartość całkowita {Name} to {value}");
            }
            return value;
        }
    }
}
