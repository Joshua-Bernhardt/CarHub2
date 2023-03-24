using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace CarHub.Service.Model.User.Get
{
    [ExcludeFromCodeCoverage]
    public class UserGetResponse
    {
        public string Forename { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string VehicleRegistration { get; set; }

        public string Email {get; set;}

        public HttpStatusCode StatusCode {get; set;}
    }
}