using CarHub.Service.Model.Vehicle.Get;
using CarHub.Service.Model.Vehicle.Post;
using CarHub.Service.Model.Vehicle.Put;

namespace CarHub.Service.Provider
{
    public interface IVehicleProvider
    {
        public VehicleGetResponse GetVehicle(VehicleGetRequest request);

        public VehiclePostResponse CreateVehicle(VehiclePostRequest request);

        public VehiclePutResponse EditVehicle(VehiclePutRequest request);
    }
}