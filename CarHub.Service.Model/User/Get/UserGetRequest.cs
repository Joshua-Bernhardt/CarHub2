using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.User.Get
{
    [ExcludeFromCodeCoverage]
    public class UserGetRequest
    {
        [Required]
        public Guid UserId {get; set;}
    }
}