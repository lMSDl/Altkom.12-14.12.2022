using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Facade.II
{
    internal class ShopFacade
    {
        ICartService cartService;
        IProductService productService;
        IPaymentService paymentService;

        public ShopFacade(ICartService cartService, IProductService productService, IPaymentService paymentService)
        {
            this.cartService = cartService;
            this.productService = productService;
            this.paymentService = paymentService;
        }

        public void Buy(int[] productIds)
        {
            foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }

            paymentService.Pay(cartService.GetId(), cartService.GetValue());
        }
    }
}
