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

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAcocunts.Remove(paymentAccount);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return PaymentAcocunts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int accountId, float amount)
        {
            PaymentAccount? account = FindAccount(accountId);
            if (account == null)
                return false;

            if (ValidateAmonut(amount, account))
                return false;

            account.Outcome += amount;
            return true;
        }

        private static bool ValidateAmonut(float amount, PaymentAccount account)
        {
            return account.Income - account.Outcome + account.AllowedDebit < amount;
        }

        private PaymentAccount? FindAccount(int accountId)
        {
            return PaymentAcocunts.SingleOrDefault(x => x.Id == accountId);
        }

        public void Fund(int accountId, float amount)
        {
            var customer = PaymentAcocunts.Where(x => x.Id == accountId).SingleOrDefault();
            if (customer == null)
                return;
            customer.Income += amount;
        }

        public float? GetBalance(int accountId)
        {
            var customer = PaymentAcocunts.Where(x => x.Id == accountId).SingleOrDefault();
            return customer?.Income - customer?.Outcome;
        }
    }
}
