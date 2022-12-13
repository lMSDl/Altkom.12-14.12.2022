using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            {
                var service = Context.Instance;
                Console.WriteLine($"Service: {service}");
            }

            {
                var service = Context.Instance;
                service.SetSettings("2", "ala ma kota");
                Console.WriteLine($"Service: {service}");
            }

            {
                var service = Context.Instance;
                Console.WriteLine($"Service: {service}");
            }
        }
    }
}
