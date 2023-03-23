using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Vehicle
{
    [ExcludeFromCodeCoverage]
    public class ServiceEntry : Entry
    {
        public ServiceType ServiceType {get; set;}

        public string Description {get; set;}
    }
}