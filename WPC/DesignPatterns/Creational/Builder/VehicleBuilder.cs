namespace WPC.DesignPatterns.Creational.Builder
{
    public class VehicleBuilder
    {
        private Vehicle Vehicle { get; set; } = new Vehicle();

        public void SetWheels(int value)
        {
            Vehicle.Wheels = value;
        }
        public void SetSeats(int value)
        {
            Vehicle.Seats = value;
        }
        public void SetTrunkCapacity(int? value)
        {
            Vehicle.TrunkCapacity = value;
        }
        public void SetDoors(int value)
        {
            Vehicle.Doors = value;
        }
        public void SetEnginePower(int? value)
        {
            Vehicle.EnginePower = value;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
