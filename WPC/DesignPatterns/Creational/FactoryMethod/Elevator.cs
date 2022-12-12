using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }
    
        private Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public Elevator()
        {
            var type = typeof(IElevatorOperation);

            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));

        }

        public IElevatorOperation? GetOperation(string action)
        {
            if(_operations.TryGetValue(action, out var result))
                return result;

            IElevatorOperation? elevatorOperation = null;
            switch (action)
            {
                case "Down":
                    elevatorOperation = new ElevatorDown();
                    break;
                case "Up":
                    elevatorOperation = new ElevatorUp();
                    break;
                case "GoTo":
                    elevatorOperation = new ElevatorUp();
                    break;
            }

            _operations[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}
