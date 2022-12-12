using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorDown : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda zatrzyma się na piętrze {floor} jadąc w dół");
        }
    }
}
