using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace CarHub.Service.Model.User
{
    [ExcludeFromCodeCoverage]
    public class Reminder
    {
        [Required]
        public Guid UserId {get; set;}

        public Guid Id {get; set;}
    }
}