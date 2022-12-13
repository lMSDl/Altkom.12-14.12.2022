using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Flyweight
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory(params CarFlyweight[] values)
        {
            _flyweights = values.ToDictionary(x => GetKey(x));
        }

        private string GetKey(CarFlyweight flyweight)
        {
            return string.Join("_",
            typeof(CarFlyweight).GetProperties()
                .Where(x => x.CanWrite && x.CanRead)
                .OrderBy(x => x.Name)
                .Select(x => x.GetValue(flyweight)));
        }

        public CarFlyweight GetFlyweight(CarFlyweight flyweight)
        {
            var key = GetKey(flyweight);

            if(!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = flyweight;
                Console.WriteLine($"Dodajemy stan wewnętrzy do słownika: {key}");
            }
            else
            {
                flyweight = _flyweights[key];
                Console.WriteLine($"Pobieramy stan wewnętrzy ze słownika: {key}");
            }

            return flyweight;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Key);
            }
        }

    }
}
