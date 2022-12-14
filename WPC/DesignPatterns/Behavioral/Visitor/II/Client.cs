using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    public class Client
    {
        public static void Execute()
        {
            var products = new List<Product> { new Product(), new BoxedProduct() };
            foreach (var item in products)
            {
                item.PrintType();
            }
            Console.WriteLine();

            var baskets = new List<Basket> { new Basket(), new Cart() };
            foreach (var basket in baskets)
            {
                foreach (var product in products)
                {
                    //basket.Add(product);
                    product.Accept(basket);
                }
            }
        }
    }
}
