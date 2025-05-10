namespace Cursework
{
    public abstract class Transport
    {
        private int _registrationNumber;
        private string _make;
        private string _model;
        private int _yearOfManufacture;
        private double _mileage;
        
        private DriverLicense _driverLicense;

        public int RegistrationNumber
        {
            get => _registrationNumber;
            set => _registrationNumber = value;
        }

        public string Make
        {
            get => _make;
            set => _make = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int YearOfManufacture
        {
            get => _yearOfManufacture;
            set => _yearOfManufacture = value;
        }

        public double Mileage
        {
            get => _mileage;
            set => _mileage = value;
        }

        protected Transport()
        {
        }

        protected Transport(int registrationNumber, string make, string model, int yearOfManufacture, double mileage,
            DriverLicense driverLicense)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            Mileage = mileage;
            _driverLicense = driverLicense;
        }
    }
}