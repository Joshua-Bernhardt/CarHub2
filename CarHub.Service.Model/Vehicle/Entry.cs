using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model
{
    [ExcludeFromCodeCoverage]
    public abstract class Entry
    {
        [Required]
        public DateTime EntryDate {get; set;}
    }
}