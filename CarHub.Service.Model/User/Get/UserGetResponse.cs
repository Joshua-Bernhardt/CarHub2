using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace CarHub.Service.Model.User.Get
{
    [ExcludeFromCodeCoverage]
    public class UserGetResponse
    {
        public User User {get; set;}

        public HttpStatusCode StatusCode {get; set;}
    }
}