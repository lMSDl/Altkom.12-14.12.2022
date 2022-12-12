using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    public class ElevatorGoTo : IElevatorOperation
    {

        public void Operate(int floor)
        {
            Console.WriteLine($"Winda tusza na piętro {floor}");
        }
    }
}
