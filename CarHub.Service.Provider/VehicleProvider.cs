using System.Net;
using CarHub.Service.Model.Vehicle.Get;
using CarHub.Service.Model.Vehicle.Post;
using CarHub.Service.Model.Vehicle.Put;
using CarHub.Service.Repository.VehicleRepository;

namespace CarHub.Service.Provider
{
    public class VehicleProvider : IVehicleProvider
    {
        private readonly IVehicleRepository _repository;

        public VehicleProvider(IVehicleRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public VehiclePostResponse CreateVehicle(VehiclePostRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            if (request.Vehicle == null) throw new InvalidOperationException();

            var response = _repository.CreateVehicle(request.Vehicle);

            if (response)
            {
                return new VehiclePostResponse()
                {
                    Created = true
                };
            }
            else
            {
                return new VehiclePostResponse()
                {
                    Created = false
                };
            }
        }

        public VehiclePutResponse EditVehicle(VehiclePutRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            if (request.Vehicle == null) throw new InvalidOperationException();

            var response = _repository.EditVehicle(request.Vehicle);

            if (response)
            {
                return new VehiclePutResponse()
                {
                    Created = true
                };
            }
            else
            {
                return new VehiclePutResponse()
                {
                    Created = false
                };
            }
        }

        public VehicleGetResponse GetVehicle(VehicleGetRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrEmpty(request.Registration)) throw new InvalidOperationException(nameof(request.Registration));

            var vehicle = _repository.GetVehicle(request.Registration);

            if (vehicle != null)
            {
                return new VehicleGetResponse()
                {
                    StatusCode = HttpStatusCode.OK,
                    Vehicle = vehicle
                };
            }
            else
            {
                return new VehicleGetResponse()
                {
                    StatusCode = HttpStatusCode.NotFound
                };
            }
        }
    }
}