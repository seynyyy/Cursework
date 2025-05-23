using System;

namespace Cursework.Models
{
    [Serializable]
    public class MaintenanceRecord
    {
        private Transport.Transport _transport;
        public string TransportRegistrationNumber => _transport?.RegistrationNumber ?? string.Empty;
        
        private string _description;
        private double _cost;
        private DateTime _date;
        
        public Transport.Transport Transport
        {
            get => _transport;
            set => _transport = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public double Cost
        {
            get => _cost;
            set => _cost = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public MaintenanceRecord()
        {
        }

        public MaintenanceRecord( string description, double cost, DateTime date)
        {
            Description = description;
            Cost = cost;
            Date = date;
        }
    }
}