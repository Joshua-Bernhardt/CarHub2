using System.Net;
using System.Diagnostics.CodeAnalysis;
namespace CarHub.Service.Model.User.Post
{
    [ExcludeFromCodeCoverage]
    public class UserPostResponse
    {
        public bool Created {get; set;}

        public string Message {get; set;}

        public HttpStatusCode StatusCode {get; set;}
    }
}