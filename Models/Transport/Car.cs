namespace Cursework.Models.Transport
{
    [System.Serializable]
    public class Car : Transport, IMaintenance
    {
        private int _passengerCapacity;
        
        public int PassengerCapacity
        {
            get => _passengerCapacity;
            set => _passengerCapacity = value;
        }
        
        public Car()
        {
        }
        
        public Car(string registrationNumber, string make, string model, int yearOfManufacture, double mileage, int passengerCapacity)
            : base(registrationNumber, make, model, yearOfManufacture, mileage)
        {
            PassengerCapacity = passengerCapacity;
        }

        protected override bool IsValidDriverLicense(DriverLicense driverLicense)
        {
            return driverLicense == DriverLicense.B;
        }

        public double CalculateTotalMaintenanceCost()
        {
            double totalCost = 0;
            foreach (var record in _maintenanceRecords)
            {
                totalCost += record.Cost;
            }
            return totalCost* 1.1;
        }

        public override string GetStatusReport()
        {
            return $"Car: {Make} {Model}, Registration: {RegistrationNumber}, Passenger Capacity: {PassengerCapacity}, Mileage: {Mileage} km, Maintenance Cost: {CalculateTotalMaintenanceCost():C}";
        }
    }
}
