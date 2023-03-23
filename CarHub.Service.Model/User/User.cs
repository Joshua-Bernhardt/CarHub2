using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.User
{
    [ExcludeFromCodeCoverage]
    public class User
    {
        public Guid Id { get; set; }

        public string Forename { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string VehicleRegistration { get; set; }

        public string Email {get; set;}

        public string Password {get; set;}
    }
}