using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(wheels: 4, seats: 5, 4, 500, 100);
            Console.WriteLine(vehicle);

            /*var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWheels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetTrunkCapacity(500);
            vehicleBuilder.SetEnginePower(100);*/

            /*var vehicleBuilder = new VehicleBuilder()
            .SetWheels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100);

            vehicle = vehicleBuilder.Build();*/

            vehicle = new VehicleBuilder()
            .SetWheels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100)
                .Build();
            Console.WriteLine(vehicle);

            vehicle = new Vehicle() { Doors = 4, EnginePower = 100, Seats = 5, Wheels = 4, TrunkCapacity = 100 };
            Console.WriteLine(vehicle);

        }
    }
}
