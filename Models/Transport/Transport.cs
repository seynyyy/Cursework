using System;
using System.Collections.Generic;

namespace Cursework.Models.Transport
{
    [Serializable]
    public abstract class Transport : IComparable<Transport>
    {
        private string _registrationNumber;
        private string _make;
        private string _model;
        private int _yearOfManufacture;
        private double _mileage;
        protected List<MaintenanceRecord> _maintenanceRecords = new List<MaintenanceRecord>();
        
        public string Type => GetType().Name;

        public string RegistrationNumber
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

        protected Transport(string registrationNumber, string make, string model, int yearOfManufacture, double mileage)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            Mileage = mileage;
        }
        
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfManufacture;
        }

        public void UpdateMileage(double newMileage)
        {
            if (newMileage > Mileage)
            {
                Mileage = newMileage;
            }
            else
            {
                throw new ArgumentException("New mileage must be greater than current mileage.");
            }
        }

        protected virtual bool IsValidDriverLicense(DriverLicense license)
        {
            return false;
        }

        public void AddMaintenanceRecord(MaintenanceRecord record)
        {
            _maintenanceRecords.Add(record);
        }

        public IEnumerable<MaintenanceRecord> GetMaintenanceRecords()
        {
            return _maintenanceRecords;
        }

        public virtual string GetStatusReport()
        {
            return $"Transport: {this.GetType().Name}, Status: Operational";
        }

        public int CompareTo(Transport other)
        {
            if (other == null) return 1;
            return string.Compare(this.RegistrationNumber, other.RegistrationNumber, StringComparison.OrdinalIgnoreCase);
        }
    }
}
