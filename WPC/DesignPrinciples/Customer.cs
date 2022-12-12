using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }

        public PaymentAccount Account { get; } = new PaymentAccount();
    }
}
