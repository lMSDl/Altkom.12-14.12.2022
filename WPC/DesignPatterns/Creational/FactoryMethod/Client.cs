using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();


            var action = "Down";
            var elevatorOperation = elevator.GetOperation(action);
            elevatorOperation = elevator.GetOperation(action);
            elevatorOperation = elevator.GetOperation(action);

            if (elevatorOperation != null)
                elevator.Execute(elevatorOperation, 3);

        }
    }
}
