using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Vehicle
{
    [ExcludeFromCodeCoverage]
    public class RecallItem
    {
        public DateTime DateIssued {get; set;}

        public string Description {get; set;}
    }
}