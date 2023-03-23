using CarHub.Service.Model.Vehicle;

namespace CarHub.Service.Repository.VehicleRepository
{
    public class DummyVehicleRepository : IVehicleRepository
    {
        private IList<Vehicle> _vehicles;

        public DummyVehicleRepository()
        {
            _vehicles = new List<Vehicle>()
            {
                new Vehicle()
                {
                    Registration = "FA17XLP",
                    Make = "Ford",
                    Model = "Focus",
                    DateRegistered = new DateTime(2017, 5, 1),
                    MOTEntries = GetMOTEntries(),
                    ServiceEntries = GetServiceEntries()
                }
            };
        }

        public bool CreateVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);

            return true;
        }

        public bool DeleteVehicle(string registration)
        {
            if (string.IsNullOrEmpty(registration)) return false;
            if (_vehicles?.Any() != false) return false;

            _vehicles.Remove(_vehicles.FirstOrDefault(x => x.Registration == registration));

            return true;
        }

        public bool EditVehicle(Vehicle vehicle)
        {
            var existingVehicle = _vehicles.FirstOrDefault(x => x.Registration == vehicle.Registration);
            if (existingVehicle != null)
            {
                existingVehicle = vehicle;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vehicle GetVehicle(string registration)
        {
            return _vehicles.FirstOrDefault(x => x.Registration == registration);
        }

        private static IList<MOTEntry> GetMOTEntries()
        {
            return new List<MOTEntry>()
            {
                new MOTEntry()
                {
                    EntryDate = new DateTime(2020, 10, 14)
                },
                new MOTEntry()
                {
                    EntryDate = new DateTime(2021, 9, 30)
                },
                new MOTEntry()
                {
                    EntryDate = new DateTime(2022, 10, 5)
                }
            };
        }

        private static IList<ServiceEntry> GetServiceEntries()
        {
            return new List<ServiceEntry>()
            {
                new ServiceEntry()
                {
                    EntryDate = new DateTime(2020, 10, 14),
                    ServiceType = ServiceType.Minor
                },
                new ServiceEntry()
                {
                    EntryDate = new DateTime(2021, 4, 2),
                    ServiceType = ServiceType.Repair,
                    Description = "Replacement windscreen wiper mechanism"
                },
                new ServiceEntry()
                {
                    EntryDate = new DateTime(2021, 9, 25),
                    ServiceType = ServiceType.Major
                }
            };
        }

        public bool AddServiceEntry(string registration, ServiceEntry serviceEntry)
        {
            if (string.IsNullOrEmpty(registration)) throw new ArgumentNullException(nameof(registration));
            if (serviceEntry == null) throw new ArgumentNullException(nameof(serviceEntry));

            var vehicle = _vehicles.FirstOrDefault(x => x.Registration == registration);

            if (vehicle == null) return false;

            vehicle.ServiceEntries.Add(serviceEntry);

            return true;
        }

        public bool AddMOTEntry(string registration, MOTEntry motEntry)
        {
            if (string.IsNullOrEmpty(registration)) throw new ArgumentNullException(nameof(registration));
            if (motEntry == null) throw new ArgumentNullException(nameof(motEntry));

            var vehicle = _vehicles.FirstOrDefault(x => x.Registration == registration);

            if (vehicle == null) return false;

            vehicle.MOTEntries.Add(motEntry);

            return true;
        }
    }
}