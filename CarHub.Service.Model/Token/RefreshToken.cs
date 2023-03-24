using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Token
{
    [ExcludeFromCodeCoverage]
    public class RefreshToken
    {
        public Guid UserId {get; set;}

        public string TokenString {get; set;}

        public DateTime ExpireAt {get; set;}
    }
}