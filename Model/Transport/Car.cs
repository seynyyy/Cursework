namespace Cursework
{
    public class Car : Transport
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
        
        public Car(int registrationNumber, string make, string model, int yearOfManufacture, double mileage, int passengerCapacity, DriverLicense driverLicense)
            : base(registrationNumber, make, model, yearOfManufacture, mileage, driverLicense)
        {
            PassengerCapacity = passengerCapacity;
        }
    }
}