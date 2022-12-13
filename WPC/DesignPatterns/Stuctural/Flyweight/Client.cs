using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color ="Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" });

            factory.ListFlyweights();
            
            var car1 = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };

            car1.Flyweight = factory.GetFlyweight(car1.Flyweight);

            var car2 = new Car
            {
                Number = "CL4127A",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };

            car2.Flyweight = factory.GetFlyweight(car2.Flyweight);

            factory.ListFlyweights();

            var newColor = (CarFlyweight)car2.Flyweight.Clone();
            newColor.Color = "Green";
            car2.Flyweight = factory.GetFlyweight(newColor);

            var car3 = new Car
            {
                Number = "CL1231S",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };
            car3.Flyweight = factory.GetFlyweight(car3.Flyweight);

            factory.ListFlyweights();


        }
    }
}
