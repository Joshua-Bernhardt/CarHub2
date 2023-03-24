using System.Diagnostics.CodeAnalysis;

namespace CarHub.Service.Model.Login
{
    [ExcludeFromCodeCoverage]
    public class LoginPostResponse
    {
        public Guid UserId {get; set;}

        public string AccessToken {get; set;}

        public string RefreshToken {get; set;}
    }
}