using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.SOLID.L;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public class Order
    {
        public ICar Car { get;  }

        public Order(ICarFactory carFactory, string type, string segment)
        {
            switch(type)
            {
                case "Sedan":
                    Car = carFactory.ManufactureSedan(segment);
                    break;

                case "Suv":
                    Car = carFactory.ManufactureSuv(segment);
                    break;
            }
        }

        public static ICarFactory GetFactory(string manufacturer)
        {
            switch (manufacturer)
            {
                case "Honda":
                    return new HondaFactory();
                case "Toyota":
                    return new ToyotaFactory();

            }
            return null;
        }

        /*public Order(string manufacturer, string type, string segment)
        {
            switch (manufacturer)
            {
                case "Honda":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new HondaCompactSedan();
                                    break;
                                case "full":
                                    Car = new HondaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new HondaCompactSuv();
                                    break;
                                case "full":
                                    Car = new HondaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
                case "Toyota":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new ToyotaCompactSedan();
                                    break;
                                case "full":
                                    Car = new ToyotaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    Car = new ToyotaCompactSuv();
                                    break;
                                case "full":
                                    Car = new ToyotaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }*/
    }
}
