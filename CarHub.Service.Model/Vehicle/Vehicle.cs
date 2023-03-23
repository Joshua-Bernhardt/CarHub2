using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace CarHub.Service.Model.Vehicle
{
    [ExcludeFromCodeCoverage]
    public class Vehicle
    {
        public Guid Id { get; set; }

        [Required]
        public string Registration { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public DateTime DateRegistered { get; set; }

        public IList<MOTEntry> MOTEntries { get; set; }

        public IList<ServiceEntry> ServiceEntries { get; set; }

        public IList<RecallItem> RecallItems { get; set; }
    }
}