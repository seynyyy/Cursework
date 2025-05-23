namespace Cursework.Models
{
    [System.Serializable]
    public class Driver
    {
        private string _name;
        private string _surname;

        private int _experience;
        private DriverLicense _license;

        private Transport.Transport _transport;
        public string TransportRegistrationNumber => Transport?.RegistrationNumber ?? string.Empty;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public int Experience
        {
            get => _experience;
            set => _experience = value;
        }

        public DriverLicense License
        {
            get => _license;
            set => _license = value;
        }

        public Transport.Transport Transport
        {
            get => _transport;
            set => _transport = value;
        }

        public Driver()
        {
        }

        public Driver(string name, string surname, int experience, DriverLicense license)
        {
            Name = name;
            Surname = surname;
            Experience = experience;
            License = license;
        }
    }
}