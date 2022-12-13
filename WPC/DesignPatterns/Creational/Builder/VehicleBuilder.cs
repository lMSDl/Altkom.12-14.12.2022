namespace WPC.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder
    {
        private Vehicle Vehicle { get; set; } = new Vehicle();

        public VehicleBuilder SetWheels(int value)
        {
            Vehicle.Wheels = value;
            return this;
        }
        public VehicleBuilder SetSeats(int value)
        {
            Vehicle.Seats = value;
            return this;
        }
        public VehicleBuilder SetTrunkCapacity(int? value)
        {
            Vehicle.TrunkCapacity = value;
            return this;
        }
        public VehicleBuilder SetDoors(int value)
        {
            Vehicle.Doors = value;
            return this;
        }
        public VehicleBuilder SetEnginePower(int? value)
        {
            Vehicle.EnginePower = value;
            return this;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
