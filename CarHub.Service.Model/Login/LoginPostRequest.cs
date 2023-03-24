using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Login
{
    [ExcludeFromCodeCoverage]
    public class LoginPostRequest
    {
        [Required]
        public string Email {get; set;}

        [Required]
        public string Password {get; set;}
    }
}