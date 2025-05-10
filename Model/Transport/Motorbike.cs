namespace Cursework
{
    public class Motorbike : Transport
    {
        public Motorbike()
        {
        }
        
        public Motorbike(int registrationNumber, string make, string model, int yearOfManufacture, double mileage,
            DriverLicense driverLicense)
            : base(registrationNumber, make, model, yearOfManufacture, mileage, driverLicense)
        {
        }
    }
}