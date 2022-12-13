using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Manufacturer { get => Flyweight.Manufacturer; set => Flyweight.Manufacturer = value; }
        public string Model { get => Flyweight.Model; set => Flyweight.Model = value; }
        public string Color { get => Flyweight.Color; set => Flyweight.Color = value; }

        public CarFlyweight Flyweight { get; set; } = new CarFlyweight();
    }
}
