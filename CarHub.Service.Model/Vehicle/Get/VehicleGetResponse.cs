using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace CarHub.Service.Model.Vehicle.Get
{
    [ExcludeFromCodeCoverage]
    public class VehicleGetResponse
    {
        public Vehicle Vehicle {get; set;}

        public HttpStatusCode StatusCode {get; set;}
    }
}