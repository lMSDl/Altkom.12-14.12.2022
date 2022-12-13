namespace WPC.DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle Vehicle { get; set; }

        protected VehicleBuilderBase(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        protected VehicleBuilderBase(): this( new Vehicle())
        {
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
