namespace Cursework
{
    public class Truck : Transport
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
        
        public Truck(int registrationNumber, string make, string model, int yearOfManufacture, double mileage, double loadCapacity, DriverLicense driverLicense)
            : base(registrationNumber, make, model, yearOfManufacture, mileage, driverLicense)
        {
            LoadCapacity = loadCapacity;
        }
    }
}