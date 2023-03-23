using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CarHub.Service.Model.Vehicle.Get
{
    [ExcludeFromCodeCoverage]
    public class VehicleGetRequest
    {
        [Required]
        [FromRoute]
        public string Registration {get; set;}
    }
}