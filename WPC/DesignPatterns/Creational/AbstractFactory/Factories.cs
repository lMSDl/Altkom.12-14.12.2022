using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{

    public class HondaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch(segment)
            {
                case "Full":
                    return new HondaFullSedan();
                case "Compact":
                    return new HondaCompactSedan();
            }
            return null;
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "Full":
                    return new HondaFullSuv();
                case "Compact":
                    return new HondaCompactSuv();
            }
            return null;
        }
    }

    public class ToyotaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "Full":
                    return new ToyotaFullSedan();
                case "Compact":
                    return new ToyotaCompactSedan();
            }
            return null;
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "Full":
                    return new ToyotaFullSuv();
                case "Compact":
                    return new ToyotaCompactSuv();
            }
            return null;
        }
    }
}
