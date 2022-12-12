using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class CustomersService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public Customer? FindById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }
    }
}
