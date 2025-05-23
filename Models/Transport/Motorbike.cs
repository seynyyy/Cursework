namespace Cursework.Models.Transport
{
    [System.Serializable]
    public class Motorbike : Transport, IMaintenance
    {
        public Motorbike()
        {
        }
        
        public Motorbike(string registrationNumber, string make, string model, int yearOfManufacture, double mileage)
            : base(registrationNumber, make, model, yearOfManufacture, mileage)
        {
        }
        
        protected override bool IsValidDriverLicense(DriverLicense driverLicense)
        {
            return driverLicense == DriverLicense.A;
        }

        public double CalculateTotalMaintenanceCost()
        {
            double totalCost = 0;
            foreach (var record in _maintenanceRecords)
            {
                totalCost += record.Cost;
            }
            return totalCost* 1.05;
        }

        public override string GetStatusReport()
        {
            return $"Motorbike: {Make} {Model}, Registration: {RegistrationNumber}, Mileage: {Mileage} km, Maintenance Cost: {CalculateTotalMaintenanceCost():C}";
        }
    }
}
