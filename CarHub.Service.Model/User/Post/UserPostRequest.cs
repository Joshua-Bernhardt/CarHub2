using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.User.Post
{
    [ExcludeFromCodeCoverage]
    public class UserPostRequest
    {
        public string Forename { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        [Required]
        public string Email {get; set;}

        public string PhoneNumber {get; set;}

        [Required]
        public string VehicleRegistration { get; set; }

        [Required]
        public string Password {get; set;}
    }
}