using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Flyweight
{
    public class CarFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowInfo(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
