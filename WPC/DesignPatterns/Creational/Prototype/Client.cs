using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p0 = new Person() { Name = "Ewa Ewowska", Age = 45, Address = new Address { City = "Warszawa", Street = "Krakowska" } };


            var p1 = (Person)p0.Clone();
            p1.Name = "Monika Monikowska";

            var p2 = (Person)p0.Clone();
            p2.Name = "Katarzyna Katarzyńska";
            p2.Age = 34;

            Console.WriteLine( JsonSerializer.Serialize(p0));
            Console.WriteLine(JsonSerializer.Serialize(p1));
            Console.WriteLine(JsonSerializer.Serialize(p2));

            p0.Address.Street = "Opolska";
            Console.WriteLine(JsonSerializer.Serialize(p0));
            Console.WriteLine(JsonSerializer.Serialize(p1));
            Console.WriteLine(JsonSerializer.Serialize(p2));

            p1.Parent = p0;

            p0.Children = new List<Person> { p1 };

            var p3 = (Person)p1.Clone(); 

        }
    }
}
