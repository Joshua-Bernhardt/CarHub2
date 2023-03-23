using System.Security.Cryptography;
using CarHub.Service.Model.Vehicle;

namespace CarHub.Service.Repository.VehicleRepository
{
    public interface IVehicleRepository
    {
        Vehicle GetVehicle(string registration);

        bool CreateVehicle(Vehicle vehicle);

        bool EditVehicle(Vehicle vehicle);

        bool DeleteVehicle(string registration);

        bool AddServiceEntry(string registration, ServiceEntry serviceEntry);
        bool AddMOTEntry(string registration, MOTEntry motEntry);
    }
}