using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            return customer.Account?.Charge(amount) ?? false;
        }

        public void Fund(Customer customer, float amount)
        {
            customer.Account?.Fund(amount);
        }
    }
}
