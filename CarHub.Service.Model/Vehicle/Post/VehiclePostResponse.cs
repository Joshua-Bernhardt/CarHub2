using System.Diagnostics.CodeAnalysis;
namespace CarHub.Service.Model.Vehicle.Post
{
    [ExcludeFromCodeCoverage]
    public class VehiclePostResponse
    {
        public bool Created {get; set;}

        public string Message {get; set;}
    }
}