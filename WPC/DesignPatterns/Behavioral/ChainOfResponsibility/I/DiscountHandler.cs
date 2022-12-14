using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : IDiscountHandler
    {
        public string Name { get; }
        public float MinPrice { get; }
        public float MaxDiscount { get; }


        private IDiscountHandler? _nextHandler { get; }

        public DiscountHandler(string name,  float maxDiscount, float minPrice) : this(name,  maxDiscount, minPrice, null)
        {
        }

        public DiscountHandler(string name,  float maxDiscount, float minPrice, IDiscountHandler? nextHandler)
        {
            Name = name;
            MinPrice = minPrice;
            MaxDiscount = maxDiscount;
            _nextHandler = nextHandler;
        }

        public bool Discount(float discountValue, float productsPrice)
        {
            if (productsPrice < MinPrice || discountValue > MaxDiscount)
            {
                return _nextHandler?.Discount( discountValue, productsPrice) ?? false;
            }
            Console.WriteLine($"{Name} udzielił rabatu");
            return true;
        }
    }
}
