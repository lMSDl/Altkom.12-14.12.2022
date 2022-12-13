namespace WPC.DesignPatterns.Creational.Builder
{
    public class VehicleManufacturingInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufacturingInfoBuilder()
        {
        }

        internal VehicleManufacturingInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufacturingInfoBuilder SetProductionDateTime(DateTime value)
        {
            Vehicle.ProductionDateTime = value;
            return this;
        }
        public VehicleManufacturingInfoBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }

    }
}
