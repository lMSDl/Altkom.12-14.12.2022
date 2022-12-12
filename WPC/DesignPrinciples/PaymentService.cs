using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAcocunts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int accountId, float amount)
        {
            PaymentAccount? account = FindById(accountId);
            return account?.Charge(amount) ?? false;
        }

        private PaymentAccount? FindById(int accountId)
        {
            return PaymentAcocunts.SingleOrDefault(x => x.Id == accountId);
        }

        public void Fund(int accountId, float amount)
        {
            var account = FindById(accountId);
            account?.Fund(amount);
        }
    }
}
