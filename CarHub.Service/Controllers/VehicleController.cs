using CarHub.Service.Model.Vehicle.Get;
using CarHub.Service.Provider;
using Microsoft.AspNetCore.Mvc;

namespace CarHub.Service.Controllers
{
    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleProvider _vehicleProvider;

        public VehicleController(IVehicleProvider vehicleProvider, ILogger<VehicleController> logger)
        {
            _vehicleProvider = vehicleProvider ?? throw new ArgumentNullException(nameof(vehicleProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{registration}")]
        public VehicleGetResponse GetVehicle([FromRoute]VehicleGetRequest request)
        {
            return _vehicleProvider.GetVehicle(request);
        }
    }
}