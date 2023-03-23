using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.User.Get
{
    [ExcludeFromCodeCoverage]
    public class UserGetRequest
    {
        [Required]
        public string Email {get; set;}

        [Required]
        public string Password {get; set;}
    }
}