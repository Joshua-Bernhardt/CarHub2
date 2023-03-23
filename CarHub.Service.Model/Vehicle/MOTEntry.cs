using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Vehicle
{
    [ExcludeFromCodeCoverage]
    public class MOTEntry : Entry
    {
        public DateTime ExpiryDate {get; set;}

        public IList<string> Defects {get; set;}

        public IList<string> Advisories {get; set;}
    }
}