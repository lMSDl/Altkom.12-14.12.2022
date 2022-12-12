using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {

            var order = new Order(Order.GetFactory("Honda"), "Suv", "Compact" );

            Console.WriteLine(order.Car.Name());
        }
    }
}
