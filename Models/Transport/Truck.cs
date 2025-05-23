namespace Cursework.Models.Transport
{
    [System.Serializable]
    public class Truck : Transport, IMaintenance
    {
        private double _loadCapacity;
        
        public double LoadCapacity
        {
            get => _loadCapacity;
            set => _loadCapacity = value;
        }
        
        public Truck()
        {
        }
        
        public Truck(string registrationNumber, string make, string model, int yearOfManufacture, double mileage, double loadCapacity)
            : base(registrationNumber, make, model, yearOfManufacture, mileage)
        {
            LoadCapacity = loadCapacity;
        }
        
        protected override bool IsValidDriverLicense(DriverLicense driverLicense)
        {
            return driverLicense == DriverLicense.C;
        }

        public double CalculateTotalMaintenanceCost()
        {
            double totalCost = 0;
            foreach (var record in _maintenanceRecords)
            {
                totalCost += record.Cost;
            }
            return totalCost* 1.2;
        }

        public override string GetStatusReport()
        {
            return $"Truck: {Make} {Model}, Registration: {RegistrationNumber}, Load Capacity: {LoadCapacity} tons, Mileage: {Mileage} km, Maintenance Cost: {CalculateTotalMaintenanceCost():C}";
        }
    }
}
