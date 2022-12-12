using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            return Charge(customer.Account, amount);
        }
        public bool Charge(PaymentAccount account, float amount)
        {
            return account?.Charge(amount) ?? false;
        }

        public void Fund(PaymentAccount account, float amount)
        {
            account?.Fund(amount);
        }
    }
}
