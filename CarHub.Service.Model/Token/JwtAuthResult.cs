using System.Diagnostics.CodeAnalysis;
namespace CarHub.Service.Model.Token
{
    [ExcludeFromCodeCoverage]
    public class JwtAuthResult
    {
        public string AccessToken {get; set;}

        public RefreshToken RefreshToken {get; set;}
    }
}